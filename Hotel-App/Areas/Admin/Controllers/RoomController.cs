using Hotel_App.Areas.Admin.Constants;
using Hotel_App.Areas.Admin.Models.ViewModels;
using Hotel_App.Areas.Admin.Utilis;
using Hotel_App.Data;
using Hotel_App.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]

    public class RoomController : Controller
    {
        private AppDbContext _dbContext;
        public RoomController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //***** Create *****//
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomCreateViewModel model, int id)
        {
            var hotel = _dbContext.Hotels.FirstOrDefault(h => h.Id == id);
            if(!ModelState.IsValid)  return View();

            Room room = new Room
            {
                RoomType = model.RoomType,
                Description = model.Description,
                NumberOfAdult = model.NumberOfAdult,
                NumberOfChildren = model.NumberOfChildren,
                Price = model.Price,
                Square = model.Square,
                Hotel = hotel
            };
            List<RoomImage> roomImages = new List<RoomImage>();
            foreach(var image in model.Files)
            {
                if(image == null)
                {
                    ModelState.AddModelError("Files", "Select an image");
                    return View();
                }
                if(!image.IsSupported())
                {
                    ModelState.AddModelError("Files", "File is unsupported");
                    return View();
                }
                if(image.IsGreaterThanGivenSize(1024))
                {
                    ModelState.AddModelError(nameof(RoomCreateViewModel.Files),
                        "File size cannot be greater than 1 mb");
                    return View();
                }

                var imgName = FileUtil.CreatedFile(Path.Combine(FileConstants.ImagePath, "rooms"), image);
                roomImages.Add(new RoomImage { ImageName = imgName });
            }
            room.RoomImages = roomImages;

            await _dbContext.Rooms.AddAsync(room);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Detail", "Dashboard", new { id = id});
        }

        //***** Delete *****//
        public async Task<IActionResult> Delete(int id)
        {
            Room room = await _dbContext.Rooms.Include(r => r.RoomImages).FirstOrDefaultAsync(r => r.Id == id);
            if(room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            Room room = await _dbContext.Rooms.FirstOrDefaultAsync(r => r.Id == id);
            if(room == null)
            {
                return NotFound();
            }
            room.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Dashboard");
        }
    }
}
