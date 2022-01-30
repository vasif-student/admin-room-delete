using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.Entities
{
    public class RoomImage : BaseEntity
    {
        public string ImageName { get; set; }
        [NotMapped]
        public ICollection<IFormFile> Files { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public bool IsMain { get; set; } = true;
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
