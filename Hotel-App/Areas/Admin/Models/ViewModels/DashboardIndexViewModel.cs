using Hotel_App.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Areas.Admin.Models.ViewModels
{
    public class DashboardIndexViewModel
    {
        public IdentityUser User { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
