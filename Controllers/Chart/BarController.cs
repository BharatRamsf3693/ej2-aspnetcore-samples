﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult Bar()
        {
            List<BarChartData> chartData = new List<BarChartData>
            {
                new BarChartData { x= "Egg", y= 2.2 }, 
                new BarChartData { x= "Fish", y= 2.4 },
                new BarChartData { x= "Misc", y= 3 }, 
                new BarChartData { x= "Tea", y= 3.1 }
            };
            ViewBag.dataSource = chartData;
            List<BarChartData> chartData1 = new List<BarChartData>
            {
                    new BarChartData { x= "Egg", y= 1.2 },
                    new BarChartData { x= "Fish", y= 1.3 },
                    new BarChartData { x= "Misc", y= 1.5 },
                    new BarChartData { x= "Tea", y= 2.2 }
            };
            ViewBag.dataSource1 = chartData1;
            return View();
        }
        public class BarChartData
        {
            public string x;
            public double y;
        }
    }
}