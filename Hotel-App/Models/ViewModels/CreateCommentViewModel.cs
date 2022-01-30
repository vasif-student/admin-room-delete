using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.ViewModels
{
    public class CreateCommentViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public int RoomId { get; set; }
    }
}
