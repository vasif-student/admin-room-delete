using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.Entities
{
    public class Comment : BaseEntity
    {
        public string FullName { get; set; }
        [EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int RoomId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public string? Image { get; set; } = "profile.jpg";

    }
}
