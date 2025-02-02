#pragma checksum "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ace085bf1d93d5dc01f807bb05ae6141c9e9044"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels.Hotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ace085bf1d93d5dc01f807bb05ae6141c9e9044", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c0919da7705681ff1011bc12c1c1670520f654", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- top bar -->
<div class=""hotel-top-bar"">
    <div class=""container"">
        <div class=""hotel-left-side"">
            <!-- logo -->
            <a href=""index.html"" class=""hotel-logo-frame"" style=""width: 50px;"">
                <img src=""img/hotellogo.png"" alt=""logo"">
            </a>
            <!-- logo end -->
        </div>
        <div class=""hotel-right-side"">
            <!-- menu -->
            <div class=""hotel-menu"">
                <nav>
                    <ul>
                        <li>
                            <a href=""index.html"">Ana Səhifə</a>
                        </li>
                        <li>
                            <a href=""about.html"">Haqqımızda</a>
                        </li>
                        <li>
                            <a href=""rooms.html"">Hotellər</a>
                        </li>
                        <li>
                            <a href=""menu.html"">Otaqlar</a>
                        </li>
                        ");
            WriteLiteral(@"<li class=""current-item"">
                            <a href=""service.html"">Xidmətlərimiz</a>
                        </li>
                        <li>
                            <a href=""contact.html"">Əlaqə</a>
                        </li>
                    </ul>
                </nav>
            </div>
            <!-- menu end -->
            <!-- action button -->
            <a href=""login.html"" class=""hotel-btn""><img src=""img/icons/bookmark.svg"" alt=""icon"">Giriş</a>
            <!-- action button end -->
        </div>
        <!-- menu button -->
        <div class=""hotel-menu-btn""><span></span></div>
        <!-- menu button end -->
    </div>
</div>
<!-- top bar end -->
<!-- banner -->
<section class=""hotel-banner-simple services"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""hotel-center hotel-title-frame"">
                    <h1 class=""hotel-mb-20 hotel-h1-inner"">Xidmətlərimiz</h1>
        ");
            WriteLiteral(@"            <p class=""hotel-mb-30"">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ab vitae, dolor harum eaque nihil iste tempora error eveniet aut adipisci.</p>
                    <ul class=""hotel-breadcrumbs"">
                        <li><a href=""index.html"">Ana Səhifə</a></li>
                        <li><span>Xidmətlərimiz</span></li>
                    </ul>
                </div>

            </div>
        </div>
    </div>
</section>
<!-- banner end -->
<!-- services -->
<section class=""hotel-p-0-80 service"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""hotel-center hotel-title-frame hotel-scroll-animation hotel-mb-100"">
                    <h2 class=""hotel-mb-20"">Bütün Xidmətlərimiz</h2>
                    <p class=""hotel-mb-30"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, culpa quasi facilis adipisci id atque tempora, nobis omnis tempore ea aspernatur sunt doloribus et ");
            WriteLiteral(@"rerum cumque hic ullam rem ad.</p>
                </div>

            </div>
            <div class=""col-lg-4"">

                <!-- service card -->
                <div class=""hotel-ath-card hotel-scroll-animation imgLoad"">
                    <div class=""hotel-cover-frame"">
                        <img class=""lozad"" data-src=""img/services/1.jpg"" alt=""cover"">
                    </div>
                    <div class=""hotel-card-description"">
                        <h3 class=""hotel-mb-10"">Lounge Bar</h3>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Laudantium, similique!</p>
                    </div>
                </div>
                <!-- service card end -->

            </div>
            <div class=""col-lg-4"">

                <!-- service card -->
                <div class=""hotel-ath-card hotel-scroll-animation imgLoad"">
                    <div class=""hotel-cover-frame"">
                        <img class=""lozad"" data-src=""img/ser");
            WriteLiteral(@"vices/2.jpg"" alt=""cover"">
                    </div>
                    <div class=""hotel-card-description"">
                        <h3 class=""hotel-mb-10"">Hovuz</h3>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Hic, laborum!</p>
                    </div>
                </div>
                <!-- service card end -->

            </div>
            <div class=""col-lg-4"">

                <!-- service card -->
                <div class=""hotel-ath-card hotel-scroll-animation imgLoad"">
                    <div class=""hotel-cover-frame"">
                        <img class=""lozad"" data-src=""img/services/3.jpg"" alt=""cover"">
                    </div>
                    <div class=""hotel-card-description"">
                        <h3 class=""hotel-mb-10"">Restorant</h3>
                        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Delectus, rerum?</p>
                    </div>
                </div>
                <!-- service");
            WriteLiteral(@" card end -->

            </div>
            <div class=""col-lg-4"">

                <!-- service card -->
                <div class=""hotel-ath-card hotel-scroll-animation imgLoad"">
                    <div class=""hotel-cover-frame"">
                        <img class=""lozad"" data-src=""img/services/4.jpg"" alt=""cover"">
                    </div>
                    <div class=""hotel-card-description"">
                        <h3 class=""hotel-mb-10"">Oyun Zalı</h3>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Mollitia, ea!</p>
                    </div>
                </div>
                <!-- service card end -->

            </div>
            <div class=""col-lg-4"">

                <!-- service card -->
                <div class=""hotel-ath-card hotel-scroll-animation imgLoad"">
                    <div class=""hotel-cover-frame"">
                        <img class=""lozad"" data-src=""img/services/5.jpg"" alt=""cover"">
                    </div>
 ");
            WriteLiteral(@"                   <div class=""hotel-card-description"">
                        <h3 class=""hotel-mb-10"">Spa Salonu</h3>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Rem, deserunt.</p>
                    </div>
                </div>
                <!-- service card end -->

            </div>
            <div class=""col-lg-4"">

                <!-- service card -->
                <div class=""hotel-ath-card hotel-scroll-animation imgLoad"">
                    <div class=""hotel-cover-frame"">
                        <img class=""lozad"" data-src=""img/services/6.jpg"" alt=""cover"">
                    </div>
                    <div class=""hotel-card-description"">
                        <h3 class=""hotel-mb-10"">İdman Zalı</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nobis, doloremque.</p>
                    </div>
                </div>
                <!-- service card end -->

            </div>
        <");
            WriteLiteral("/div>\r\n    </div>\r\n</section>\r\n<!-- services end -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
