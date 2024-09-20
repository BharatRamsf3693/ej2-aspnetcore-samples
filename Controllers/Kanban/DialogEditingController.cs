#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;
namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class KanbanController : Controller
    {
 
        public IActionResult DialogEditing()
        {

            ViewBag.data = new KanbanDataModels().KanbanTasks();
            ViewBag.status = new KanbanDataModels().DialogStatus();
            ViewBag.assignee = new KanbanDataModels().AssigneeData();
            ViewBag.priority = new KanbanDataModels().PriorityData();
            return View();
        }
    }
}
