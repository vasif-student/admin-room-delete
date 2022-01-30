using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.Entities
{
    public class RentRoom : BaseEntity
    {
        public int RoomId { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public Room Room { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
