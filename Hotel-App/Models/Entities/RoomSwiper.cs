using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.Entities
{
    public class RoomSwiper : BaseEntity
    {
        public string Image { get; set; }
        public string Badge { get; set; }
        public string BedIcon { get; set; }
        public string NumberOfPeople { get; set; }
        public string SquareIcon { get; set; }
        public string Square { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PerNight { get; set; }
        public string BookmarkIcon { get; set; }
        public string Reservation { get; set; }
    }
}
