using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.Entities
{
    public class Feature : BaseEntity
    {
        public string ImageName { get; set; }
        public string Title { get; set; }
    }
}
