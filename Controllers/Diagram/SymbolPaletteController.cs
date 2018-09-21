﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2CoreSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public IActionResult SymbolPalette()
        {
            List<DiagramNode> SymbolPaletee = new List<DiagramNode>();
            SymbolPaletee.Add(new DiagramNode() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Process", Shape = new { type = "Flow", shape = "Process" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Decision", Shape = new { type = "Flow", shape = "Decision" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Document", Shape = new { type = "Flow", shape = "Document" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "PreDefinedProcess", Shape = new { type = "Flow", shape = "PreDefinedProcess" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "PaperTap", Shape = new { type = "Flow", shape = "PaperTap" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "DirectData", Shape = new { type = "Flow", shape = "DirectData" } });
            SymbolPaletee.Add(new DiagramNode() { Id = "SequentialData", Shape = new { type = "Flow", shape = "SequentialData" } });


            List<DiagramNode> BasicNodes = new List<DiagramNode>();
            BasicNodes.Add(new DiagramNode() { Id = "Rectangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle } });
            BasicNodes.Add(new DiagramNode() { Id = "Ellipse", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse } });
            BasicNodes.Add(new DiagramNode() { Id = "Parallelogram", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Parallelogram } });
            BasicNodes.Add(new DiagramNode() { Id = "Triangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Triangle } });
            BasicNodes.Add(new DiagramNode() { Id = "Hexagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Hexagon } });
            BasicNodes.Add(new DiagramNode() { Id = "Pentagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Pentagon } });
            BasicNodes.Add(new DiagramNode() { Id = "Cylinder", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Cylinder } });
            BasicNodes.Add(new DiagramNode() { Id = "Star", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Star } });
            ViewBag.BasicShapes = BasicNodes;

            List<DiagramConnector> connector = new List<DiagramConnector>();
            connector.Add(new DiagramConnector() { Id = "link1", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow }, Style = new DiagramStrokeStyle() { StrokeWidth = 2 } });
            connector.Add(new DiagramConnector() { Id = "link3", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });
            connector.Add(new DiagramConnector() { Id = "Link21", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow }, Style = new DiagramStrokeStyle() { StrokeWidth = 2 } });
            connector.Add(new DiagramConnector() { Id = "link23", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });
            connector.Add(new DiagramConnector() { Id = "link33", Type = Segments.Bezier, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });
            ViewBag.Connectors = connector;

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = SymbolPaletee, IconCss = "e-ddb-icons e-basic", Title = "Flow Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "basic", Expanded = true, Symbols = BasicNodes, IconCss = "e-ddb-icons e-flow", Title = "Basic Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = true, Symbols = connector, IconCss = "e-ddb-icons e-connector", Title = "Connectors" });
            ViewBag.palettes = palettes;

            List<ExpandOptions> expand = new List<ExpandOptions>();
            expand.Add(new ExpandOptions() { text = "Single", value = "single" });
            expand.Add(new ExpandOptions() { text = "Multiple", value = "multiple" });

            ViewBag.expand = expand;

            DiagramMargin margin = new DiagramMargin() { Left = 15, Bottom = 15, Right = 15, Top = 15 };
            ViewBag.margin = margin;

            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getSymbolInfo = "getSymbolInfo";
            ViewBag.valueChanged = "valueChanged";
            ViewBag.expandValue = "Multiple";
            return View();
        }
    }

    public class ExpandOptions
    {
        public string text;
        public string value;
    }
}