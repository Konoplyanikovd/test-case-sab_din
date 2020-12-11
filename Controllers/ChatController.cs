using System.Diagnostics;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net_example.Models;
using net_example.Data;

namespace net_example.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ModelsContext _context;

        public ChatController(ILogger<HomeController> logger, ModelsContext context)
        {
            _context = context;

            _logger = logger;
        }

        public IActionResult Index()
        {
            UserModel user =  _context.UserModel.Where(u => u.LastName == "Konoplyanikov").First();
            ViewData["Title"] = "Den's .net chat example";
            ViewBag.Messages = _context.MessageModel.Where(m => m.ChatId == 1).ToList();
            return View(user);
        }

        [HttpGet]
        public JsonResult Messages([FromQuery] int chat)
        {
            return Json(_context.MessageModel.ToList());
        }
        
        [HttpPost]
        public IActionResult Message([FromForm] string message, [FromForm] int chat, [FromForm] int user)
        {
            try 
            {
                _context.MessageModel.Add(new MessageModel {
                    Message = message,
                    ChatId = chat,
                    UserId = user
                });

                _context.SaveChanges();
                return Json("{ message: ok }");
            } catch (FormatException) 
            {
                return BadRequest();
            }
        }
    }
}
