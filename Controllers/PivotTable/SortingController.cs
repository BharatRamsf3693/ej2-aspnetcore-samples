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
using EJ2CoreSampleBrowser.Models;


namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class PivotTableController : Controller
    {

        public IActionResult Sorting()
        {
            ViewBag.data = new PivotTableData().GetPivot_Data();
            ViewBag.fielddata = GetFieldData();
            ViewBag.sortdata = GetSortData();
            return View();
        }

        public List<FieldData> GetFieldData()
        {
            List<FieldData> fieldData = new List<FieldData>();
            fieldData.Add(new FieldData { Field = "Country", Order = "Country_asc" });
            fieldData.Add(new FieldData { Field = "Products", Order = "Products_asc" });
            fieldData.Add(new FieldData { Field = "Year", Order = "Year_asc" });
            fieldData.Add(new FieldData { Field = "Order Source", Order = "Order Source_asc" });
            return fieldData;
        }

        public List<DropDownData> GetSortData()
        {
            List<DropDownData> sortData = new List<DropDownData>();
            sortData.Add(new DropDownData { Name = "Ascending", Value = "Ascending" });
            sortData.Add(new DropDownData { Name = "Descending", Value = "Descending" });
            return sortData;
        }
        public class FieldData
        {
            public string Field { get; set; }
            public string Order { get; set; }
        }
    }
}
