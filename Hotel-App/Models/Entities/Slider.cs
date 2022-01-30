using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.Entities
{
    public class Slider : BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }
}
