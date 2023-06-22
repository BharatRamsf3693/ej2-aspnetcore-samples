#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class RichtextEditorController : Controller
    {
        public IActionResult Image()
        {
            ViewBag.data = new FormatOption().SaveFormat();
            object tools1 = new
            {
                tooltipText = "Rotate Left",
                template = "<button class='e-tbar-btn e-btn' id='roatateLeft'><span class='e-btn-icon e-icons e-rotate-left'></span>"
            };
            object tools2 = new
            {
                tooltipText = "Rotate Right",
                template = "<button class='e-tbar-btn e-btn' id='roatateRight'><span class='e-btn-icon e-icons e-rotate-right'></span>"
            };
            ViewBag.image = new[] {
                "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "-",
                "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension", tools1, tools2
            };
            return View();
        }
    }
}
