using Microsoft.AspNetCore.Mvc;
using PurpChat.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurpChat.ViewComponents
{
    public class GroupViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public GroupViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var allChats = _dbContext.Chats.ToList();
            return View(allChats);
        }
    }
}
