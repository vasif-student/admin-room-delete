using Hotel_App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Areas.Admin.Models.ViewModels
{
    public class HotelViewModel
    {
        public Hotel Hotel { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
