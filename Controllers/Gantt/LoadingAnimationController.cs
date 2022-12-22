#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Threading.Tasks;
using EJ2CoreSampleBrowser.Models;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Gantt;

namespace EJ2CoreSampleBrowser.Controllers.Gantt
{
    public partial class GanttController : Controller
    {
        public IActionResult LoadingAnimation()
        {
            ViewBag.dataSource = GanttData.VirtualData();
            ViewBag.typedropdata = new string[] { "Shimmer", "Spinner" };
      
            return View();
        }
    }
}