using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PurpChat.Database;
using PurpChat.Models;

namespace PurpChat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger,AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Chat(int id)
        {
            var chat = _dbContext.Chats
                .Include(p=>p.Messages)
                .FirstOrDefault(p => p.Id == id);
            return View(chat);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroupChat(string name)
        {
            var newChat = new Chat
            {
                Name = name,
                Type=ChatType.Group
            };
            _dbContext.Chats.Add(newChat);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrivateChat(string personName)
        {
            var newChat = new Chat
            {
                Name = personName,
                Type = ChatType.Private
            };
            _dbContext.Chats.Add(newChat);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
