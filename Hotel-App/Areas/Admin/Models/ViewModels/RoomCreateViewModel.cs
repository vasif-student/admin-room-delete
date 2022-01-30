using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Areas.Admin.Models.ViewModels
{
    public class RoomCreateViewModel
    {
        public string RoomType { get; set; }
        public string Description { get; set; }
        public byte NumberOfAdult { get; set; }
        public byte NumberOfChildren { get; set; }
        public string Square { get; set; }
        public ushort Price { get; set; }
        public IFormFile[] Files { get; set; }
    }
}
