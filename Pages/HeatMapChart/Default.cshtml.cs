#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJ2CoreSampleBrowser_NET8.Pages.HeatMapChart;

public class Default : PageModel
{
    public int[,] GetDataSource()
    {
        int[,] data = new int[12, 6];
        for (int x = 0; x < 12; x++)
        {
            for (int y = 0; y < 6; y++)
            {
                Random random = new Random();
                data[x, y] = random.Next(0, 100);
            }
        }
        return data;
    }
    public void OnGet()
    {
        
    }
}