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
using Syncfusion.EJ2.Charts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ChartController : Controller
    {

        public IActionResult RangeSelection()
        {
            List<RangeSelectionData> chartData = new List<RangeSelectionData>
            {
               new RangeSelectionData { x = 1971, y1 = 50, y2 = 23},
               new RangeSelectionData { x = 1972, y1 = 20, y2 = 63},
               new RangeSelectionData { x = 1973, y1 = 63, y2 = 83},
               new RangeSelectionData { x = 1974, y1 = 81, y2 = 43},
               new RangeSelectionData { x = 1975, y1 = 64, y2 = 8},
               new RangeSelectionData { x = 1976, y1 = 36, y2 = 41},
               new RangeSelectionData { x = 1977, y1 = 22, y2 = 56},
               new RangeSelectionData { x = 1978, y1 = 78, y2 = 31},
               new RangeSelectionData { x = 1979, y1 = 60, y2 = 29},
               new RangeSelectionData { x = 1980, y1 = 41, y2 = 87},
               new RangeSelectionData { x = 1981, y1 = 12, y2 = 43},
               new RangeSelectionData { x = 1982, y1 = 56, y2 = 12},
               new RangeSelectionData { x = 1983, y1 = 96, y2 = 38},
               new RangeSelectionData { x = 1984, y1 = 48, y2 = 67},
               new RangeSelectionData { x = 1985, y1 = 23, y2 = 49},
               new RangeSelectionData { x = 1986, y1 = 54, y2 = 67},
               new RangeSelectionData { x = 1987, y1 = 73, y2 = 83},
               new RangeSelectionData { x = 1988, y1 = 56, y2 = 16},
               new RangeSelectionData { x = 1989, y1 = 69, y2 = 89},
               new RangeSelectionData { x = 1990, y1 = 79, y2 = 18 },
               new RangeSelectionData { x = 1991, y1 = 18, y2 = 46 },
               new RangeSelectionData { x = 1992, y1 = 78, y2 = 39 },
               new RangeSelectionData { x = 1993, y1 = 92, y2 = 18 },
               new RangeSelectionData { x = 1994, y1 = 93, y2 = 87 },
               new RangeSelectionData { x = 1995, y1 = 29, y2 = 45 },
               new RangeSelectionData { x = 1996, y1 = 14, y2 = 42 },
               new RangeSelectionData { x = 1997, y1 = 85, y2 = 28 },
               new RangeSelectionData { x = 1998, y1 = 24, y2 = 82 },
               new RangeSelectionData { x = 1999, y1 = 11, y2 = 13 },
               new RangeSelectionData { x = 2000, y1 = 80, y2 = 83 },
               new RangeSelectionData { x = 2001, y1 = 14, y2 = 26 },
               new RangeSelectionData { x = 2002, y1 = 34, y2 = 57 },
               new RangeSelectionData { x = 2003, y1 = 81, y2 = 48 },
               new RangeSelectionData { x = 2004, y1 = 70, y2 = 84 },
               new RangeSelectionData { x = 2005, y1 = 80, y2 = 64 },
               new RangeSelectionData { x = 2006, y1 = 70, y2 = 24 },
               new RangeSelectionData { x = 2007, y1 = 32, y2 = 82 },
               new RangeSelectionData { x = 2008, y1 = 43, y2 = 37 },
               new RangeSelectionData { x = 2009, y1 = 21, y2 = 68 },
               new RangeSelectionData { x = 2010, y1 = 63, y2 = 37 },
               new RangeSelectionData { x = 2011, y1 = 9, y2 = 35 },
               new RangeSelectionData { x = 2012, y1 = 51, y2 = 81 },
               new RangeSelectionData { x = 2013, y1 = 25, y2 = 38 },
               new RangeSelectionData { x = 2014, y1 = 96, y2 = 51 },
               new RangeSelectionData { x = 2015, y1 = 32, y2 = 58 },

             };
            ViewBag.dataSource = chartData;
            ViewBag.data = new String[] { "DragXY", "DragX", "DragY", "Lasso" };
            return View();
        }
        public class RangeSelectionData
        {            
            public double x;
            public double y1;
            public double y2;
        }
    }
}
