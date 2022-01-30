using Hotel_App.Data;
using Hotel_App.Models.ViewModels;
using Hotel_App.Models.ViewModels.Hotel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Controllers
{
    public class HotelController : Controller
    {
        private AppDbContext _dbContext;

        public HotelController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var hotels = await _dbContext.Hotels.Where(h => h.IsDeleted != true).ToListAsync();
            var hotelList = new List<HotelViewModel>();

            foreach (var hotel in hotels)
            {
                hotelList.Add(new HotelViewModel
                {
                    Name = hotel.Name,
                    Description = hotel.Description,
                    Image = hotel.Image
                });
            }
            return View(hotelList);
        }
    }
}
