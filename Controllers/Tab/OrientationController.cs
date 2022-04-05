#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class TabController : Controller
    {
        public IActionResult Orientation()
        {
            ViewBag.headerRome = new TabHeader { Text = "Rome" };
            ViewBag.headerParis = new TabHeader { Text = "Paris" };
            ViewBag.headerLondon = new TabHeader { Text = "London" };
            
            ViewBag.styleData = new string[] { "Default", "Fill", "Accent" };
            ViewBag.orientationData = new string[] { "Top", "Bottom", "Left", "Right" };
                        
            List<object> rome = new List<object>();
            rome.Add(new { Id = "1", Name = "Anne Dodsworth", Role = "Product Manager" });
            rome.Add(new { Id = "2", Name = "Laura Callahan", Role = "Team Lead" });
            rome.Add(new { Id = "3", Name = "Andrew Fuller", Role = "Developer" });

            List<object> paris = new List<object>();
            paris.Add(new { Id = "4", Name = "Robert King", Role = "Team Lead" });
            paris.Add(new { Id = "5", Name = "Michael Suyama", Role = "Developer" });
            paris.Add(new { Id = "6", Name = "Margaret Peacock", Role = "Developer" });

            List<object> london = new List<object>();
            london.Add(new { Id = "7", Name = "Janet Leverling", Role = "CEO" });
            london.Add(new { Id = "8", Name = "Steven Buchanan", Role = "HR" });
            london.Add(new { Id = "9", Name = "Nancy Davolio", Role = "Product Manager" });

            ViewBag.romeData = rome;
            ViewBag.parisData = paris;
            ViewBag.londonData = london;
            return View();
        }
    }
}
