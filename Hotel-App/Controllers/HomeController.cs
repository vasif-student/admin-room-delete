using Hotel_App.Data;
using Hotel_App.Models;
using Hotel_App.Models.Entities;
using Hotel_App.Models.ViewModels;
using Hotel_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(new HomeViewModel
            {
                Banners = await _dbContext.Banners.FirstOrDefaultAsync(),
                BannerImages = await _dbContext.BannerImages.FirstOrDefaultAsync(),
                Features = await _dbContext.Features.ToListAsync(),
                Swipers = await _dbContext.Swipers.ToListAsync(),
                RoomSwipers = await _dbContext.RoomSwipers.ToListAsync(),
                Sliders = await _dbContext.Sliders.ToListAsync()
            });
        }

        //***** Search *****//
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(RoomSearchViewModel model)
        {
            var rentrooms = await _dbContext.RentRooms.ToListAsync();
            var rooms = await _dbContext.Rooms.Include(r => r.RoomImages).Where(r =>
            (model.NumberOfAdult != null ? r.NumberOfAdult == model.NumberOfAdult : true) &&
            (model.NumberOfChildren != null ? r.NumberOfChildren == model.NumberOfChildren : true)).ToListAsync();

            var searchedRoomList = new List<Room>();
            foreach (var room in rooms)
            {
                foreach (var rentroom in rentrooms)
                {
                    if(room.Id == rentroom.RoomId)
                    {
                        if((model.StartDate < rentroom.CheckIn || model.StartDate > rentroom.CheckOut) && 
                            (model.EndDate < rentroom.CheckIn || model.EndDate > rentroom.CheckOut))
                        {
                            searchedRoomList.Add(room);
                        }
                    }
                    searchedRoomList.Add(room);
                }
            }
            return View(searchedRoomList);
            
        }

    }
}
