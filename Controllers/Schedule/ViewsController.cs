﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;


namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {

        public IActionResult Views()
        {
            ViewBag.appointments = new ScheduleData().GetZooEventData();
            ViewBag.data = GetViewData();
            return View();
        }

        public List<ViewData> GetViewData()
        {
            List<ViewData> view = new List<ViewData>();
            view.Add(new ViewData { Name = "Day", Value = "Day" });
            view.Add(new ViewData { Name = "Week", Value = "Week" });
            view.Add(new ViewData { Name = "Work Week", Value = "WorkWeek" });
            view.Add(new ViewData { Name = "Month", Value = "Month" });
            return view;
        }
    }

    public class ViewData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
