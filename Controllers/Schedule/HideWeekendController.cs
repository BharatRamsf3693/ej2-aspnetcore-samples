#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;


namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {

        public IActionResult HideWeekend()
        {
            ViewBag.appointments = new ScheduleData().GetEmployeeEventData();
            ViewBag.WorkDaysData = GetWorkDaysData();
            ViewBag.workDays = new int[] { 1, 3, 4, 5 };
            ViewBag.selectedDays = new string[] { "1", "3", "4", "5" };
            return View();
        }

        public List<GetData> GetWorkDaysData()
        {
            List<GetData> workDays = new List<GetData>();
            workDays.Add(new GetData { Name = "Sunday", Code = "0" });
            workDays.Add(new GetData { Name = "Monday", Code = "1" });
            workDays.Add(new GetData { Name = "Tuesday", Code = "2" });
            workDays.Add(new GetData { Name = "Wednesday", Code = "3" });
            workDays.Add(new GetData { Name = "Thursday", Code = "4" });
            workDays.Add(new GetData { Name = "Friday", Code = "5" });
            workDays.Add(new GetData { Name = "Saturday", Code = "6" });
            return workDays;
        }
    }
    public class GetData
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}