using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.Entities
{
    public class Room : BaseEntity
    {
        public string RoomType { get; set; }
        public string Description { get; set; }
        public byte NumberOfAdult { get; set; }
        public byte? NumberOfChildren { get; set; }
        public string Square { get; set; }
        public ushort Price { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Hotel Hotel { get; set; }
        public ICollection<RoomImage> RoomImages { get; set; }
    }
}
