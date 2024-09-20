#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJ2CoreSampleBrowser_NET8.Pages.Chart
{
    public class PieLegendModel : PageModel
    {
        public List<PieDataPoints> PieChartPoints { get; set; }
        public void OnGet()
        {
            PieChartPoints = new List<PieDataPoints>  
            {
                new PieDataPoints { ExpenseCategory =  "Internet Explorer", ExpensePercentage = 6.12, LegendName="Internet <br> Explorer", DataLabelMappingName = "6.12%" },
                new PieDataPoints { ExpenseCategory =  "Chrome", ExpensePercentage = 57.28, LegendName="Chrome", DataLabelMappingName = "57.28%" },
                new PieDataPoints { ExpenseCategory =  "Safari", ExpensePercentage = 4.73, LegendName="Safari", DataLabelMappingName = "4.73%" },
                new PieDataPoints { ExpenseCategory =  "QQ", ExpensePercentage = 5.96, LegendName="QQ", DataLabelMappingName = "5.96%" },
                new PieDataPoints { ExpenseCategory =  "UC Browser", ExpensePercentage = 4.37, LegendName="UC Browser", DataLabelMappingName = "4.37%" },
                new PieDataPoints { ExpenseCategory =  "Edge", ExpensePercentage = 7.48, LegendName="Edge", DataLabelMappingName = "7.48%" },
                new PieDataPoints { ExpenseCategory =  "Others", ExpensePercentage = 14.06, LegendName="Others", DataLabelMappingName = "14.06%" }
            };
        }
    }
    public class PieDataPoints
    {
        public string ExpenseCategory;
        public double ExpensePercentage;
        public string LegendName;
        public string DataLabelMappingName;
    }
    
}