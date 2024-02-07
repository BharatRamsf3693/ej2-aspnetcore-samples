#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2CoreSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public IActionResult LogicCircuit()
        {
            string orData = "M21.7,76.5L21.7,76.5c6.4-18.1,6.4-37.8,0-55.9l0-0.1h1.6c21.5,0,41.7,10.4,54.2,28l0,0l0,0  c-12.5,17.6-32.7,28-54.2,28H21.7z M99.5,48.5l-22,0 M0,31.5h25 M0,65.5h25";
            string andData = "M21.5,20.5h28a28,28,0,0,1,28,28v0a28,28,0,0,1-28,28h-28a0,0,0,0,1,0,0v-56a0,0,0,0,1,0,0Z M78,48.5 L 100,48.5Z M0,32.5 L 21.4,32.5Z M0,65.5 L 21.4,65.5Z";
            string notData = "M75.5,50.5l-52,28v-56L75.5,50.5z M81.5,50.5h18 M1.5,50.5h22 M78.5,47.5c-1.7,0-3,1.3-3,3s1.3,3,3,3s3-1.3,3-3  S80.2,47.5,78.5,47.5z";
            /* tslint:enable */

            // defines the shapes connection points
            List<DiagramPort> orPort = new List<DiagramPort>();
            orPort.Add(new DiagramPort() { Id = "Or_port1", Offset = new DiagramPoint() { X = 0.01, Y = 0.1963 } });
            orPort.Add(new DiagramPort() { Id = "Or_port2", Offset = new DiagramPoint() { X = 0.26, Y = 0.5 } });
            orPort.Add(new DiagramPort() { Id = "Or_port3", Offset = new DiagramPoint() { X = 0.01, Y = 0.805 } });
            orPort.Add(new DiagramPort() { Id = "Or_port4", Offset = new DiagramPoint() { X = 0.99, Y = 0.5 } });


            List<DiagramPort> andPort = new List<DiagramPort>();
            andPort.Add(new DiagramPort() { Id = "And_port1", Offset = new DiagramPoint() { X = 0.01, Y = 0.215 } });
            andPort.Add(new DiagramPort() { Id = "And_port2", Offset = new DiagramPoint() { X = 0.22, Y = 0.5 } });
            andPort.Add(new DiagramPort() { Id = "And_port3", Offset = new DiagramPoint() { X = 0.01, Y = 0.805 } });
            andPort.Add(new DiagramPort() { Id = "And_port4", Offset = new DiagramPoint() { X = 0.99, Y = 0.5 } });

            List<DiagramPort> notPort = new List<DiagramPort>(); notPort.Add(new DiagramPort() { Id = "Not_port1", Offset = new DiagramPoint() { X = 0.01, Y = 0.5 } });
            notPort.Add(new DiagramPort() { Id = "Not_port2", Offset = new DiagramPoint() { X = 0.99, Y = 0.5 } });

            List<DiagramPort> flipPorts = new List<DiagramPort>();
            flipPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.215 } });
            flipPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.785 } });
            flipPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.215 } });
            flipPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.785 } });

            List<DiagramPort> jkPorts = new List<DiagramPort>();
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.27 } });
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.5 } });
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.73 } });
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.27 } });
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.73 } });
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.5, Y = 0.01 } });
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.5, Y = 0.99 } });

            List<DiagramPort> rPorts = new List<DiagramPort>();
            rPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.215 } });
            rPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.785 } });
            rPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.5, Y = 0.215 } });
            rPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.215 } });
            jkPorts.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.785 } });

            DiagramDecorator decorator = new DiagramDecorator() { Height = 12, Width = 12, Shape = DecoratorShapes.Circle, Style = new DiagramShapeStyle() { Fill = "White", StrokeColor = "#444", StrokeWidth = 2 } };


            List<DiagramNode> Nodes = new List<DiagramNode>();
            Nodes.Add(CreateNode("OR1", 336, 161.5, 70, 104, orData, orPort));
            Nodes.Add(CreateNode("OR2", 336, 329, 70, 104, orData, orPort));
            Nodes.Add(CreateNode("OR3", 336, 470, 70, 104, orData, orPort));
            Nodes.Add(CreateNode("Not1", 157, 267, 58, 100, notData, notPort));
            Nodes.Add(CreateNode("Not2", 135, 329, 58, 100, notData, notPort));
            Nodes.Add(CreateNode("Not3", 157, 470, 58, 100, notData, notPort));
            Nodes.Add(CreateNode("And", 543, 329, 70, 104, andData, andPort));
            ViewBag.Nodes = Nodes;

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(createConnector("line1", new DiagramPoint() { X = 140, Y = 130 }, null, null, "OR1", null, "Or_port1", decorator, null, new DiagramConnectorAnnotation() { Content = "A", Margin = new DiagramMargin() { Left = -20 } }, true, false));
            Connectors.Add(createConnector("line2", new DiagramPoint() { X = 140, Y = 161.5 }, null, null, "OR1", null, "Or_port2", decorator, null, new DiagramConnectorAnnotation() { Content = "B", Margin = new DiagramMargin() { Left = -20 } }, true, false));
            Connectors.Add(createConnector("line3", new DiagramPoint() { X = 140, Y = 195 }, null, null, "OR1", null, "Or_port3", decorator, null, new DiagramConnectorAnnotation() { Content = "C", Margin = new DiagramMargin() { Left = -20 } }, true, false));
            Connectors.Add(createConnector("line4", new DiagramPoint() { X = 85, Y = 267 }, null, null, "Not1", null, "Not_port1", decorator, null, new DiagramConnectorAnnotation() { Content = "A", Margin = new DiagramMargin() { Left = -20 } }, false, false));
            Connectors.Add(createConnector("line5", new DiagramPoint() { X = 65, Y = 329 }, null, null, "Not2", null, "Not_port1", decorator, null, new DiagramConnectorAnnotation() { Content = "B", Margin = new DiagramMargin() { Left = -20 } }, false, false));
            Connectors.Add(createConnector("line6", new DiagramPoint() { X = 85, Y = 470 }, null, null, "Not3", null, "Not_port1", decorator, null, new DiagramConnectorAnnotation() { Content = "C", Margin = new DiagramMargin() { Left = -20 } }, false, false));
            Connectors.Add(createConnector("line7", null, null, "Not1", "OR2", "Not_port2", "Or_port1", null, null, new DiagramConnectorAnnotation() { Content = "A'", Margin = new DiagramMargin() { Left = 0, Top = -20 } }, false, false));
            Connectors.Add(createConnector("line8", null, null, "Not2", "OR2", "Not_port2", "Or_port2", null, null, new DiagramConnectorAnnotation() { Content = "B'", Margin = new DiagramMargin() { Left = 0, Top = -20 } }, false, false));
            Connectors.Add(createConnector("line9", new DiagramPoint() { X = 140, Y = 380 }, null, null, "OR2", null, "Or_port3", decorator, null, null, true, false));
            Connectors.Add(createConnector("line10", new DiagramPoint() { X = 140, Y = 420 }, null, null, "OR3", null, "Or_port1", decorator, null, null, true, false));
            Connectors.Add(createConnector("line11", null, null, "Not3", "OR3", "Not_port2", "Or_port2", null, null, new DiagramConnectorAnnotation() { Content = "B'", Margin = new DiagramMargin() { Left = 0, Top = -20 } }, false, false));
            Connectors.Add(createConnector("line12", new DiagramPoint() { X = 140, Y = 520 }, null, null, "OR3", null, "Or_port3", decorator, null, null, true, false));
            Connectors.Add(createConnector("line13", null, null, "OR1", "And", "Or_port4", "And_port1", null, null, new DiagramConnectorAnnotation() { Content = "(A + B + C)", Margin = new DiagramMargin() { Left = 0, Top = -20 } }, true, false));
            Connectors.Add(createConnector("line14", null, null, "OR2", "And", "Or_port4", "And_port2", null, null, new DiagramConnectorAnnotation() { Content = "(A' + B' + C)", Margin = new DiagramMargin() { Left = 0, Top = -20 } }, true, false));
            Connectors.Add(createConnector("line15", null, null, "OR3", "And", "Or_port4", "And_port3", null, null, new DiagramConnectorAnnotation() { Content = "(A + B' + C)", Margin = new DiagramMargin() { Left = 0, Top = -20 } }, true, false));
            Connectors.Add(createConnector("line16", null, new DiagramPoint() { X = 600, Y = 329 }, "And", null, "And_port4", null, null, decorator, new DiagramConnectorAnnotation() { Content = "F =(A+B+C)*(A+B'+C)*(A+B'+C)", Margin = new DiagramMargin() { Left = -80, Top = 60 } }, true, true));
            ViewBag.Connectors = Connectors;


            List<Syncfusion.EJ2.Diagrams.DiagramNode> LogigGates = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();

            LogigGates.Add(new DiagramNode()
            { Id = "Or", Shape = new { type = "Path", data = orData }, Ports = orPort });
            LogigGates.Add(new DiagramNode()
            {
                Id = "Nor",
                Shape = new { type = "Path", data = "M21.7,76.5L21.7,76.5c6.4-18.1,6.4-37.8,0-55.9l0-0.1h1.6c21.5,0,41.7,10.4,54.2,28l0,0l0,0  c-12.5,17.6-32.7,28-54.2,28H21.7z M83.5,48.5h16 M1.5,32.5h24 M1.5,64.5h24 M80.5,45.5c-1.7,0-3,1.3-3,3s1.3,3,3,3s3-1.3,3-3  S82.2,45.5,80.5,45.5z" }
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "And",
                Shape = new { type = "Path", data = andData },
                Ports = andPort
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "Nand",
                Shape = new { type = "Path", data = "M49.5,76.5h-28v-56h28c15.5,0,28,12.5,28,28v0C77.5,64,65,76.5,49.5,76.5z M83.5,48.5h16 M1.5,32.5h20   M1.5,65.5h20 M80.5,45.5c-1.7,0-3,1.3-3,3s1.3,3,3,3s3-1.3,3-3S82.2,45.5,80.5,45.5z" },
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "not",
                Shape = new { type = "Path", data = notData },
                Ports = notPort
            });

            List<DiagramPort> port = new List<DiagramPort>();
            port.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.5 } });
            port.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.5 } });
            LogigGates.Add(new DiagramNode()
            {
                Id = "Buffer",
                Shape = new { type = "Path", data = "M170.354,66.6523000000002L199.753,83.6253000000002L170.354,100.5983L170.354,66.6523000000002zM199.7534,83.6255000000001L214.5004,83.6255000000001M154.5,83.6255000000001L170.354,83.6255000000001" },
                Ports = port
            });
            port = new List<DiagramPort>();
            port.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.19 } });
            port.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.01, Y = 0.809 } });
            port.Add(new DiagramPort() { Offset = new DiagramPoint() { X = 0.99, Y = 0.5 } });
            LogigGates.Add(new DiagramNode()
            {
                Id = "NorGate",
                Shape = new
                {
                    type = "Path",
                    data = "M14.5055,0.00562288 C14.3031,0.00562288 14.1078,0.0433293 13.9072,0.0542443 L13.9072,49.959 C14.1078,49.9699 14.3031,50.0079 14.5055,50.0079 C23.223,50.0079 30.29,28.3205 30.29,25.004 C30.29,22.2835 23.223,0.00562288 14.5055,0.00562288 z M13.9074,9.48911 L-0.00120828,9.48911 M13.9074,40.5218 L-0.00120828,40.5218 M36.3023,25.005 L50.0033,25.005 M36.2352,25.005 C36.2352,29.5191 35.0457,33.1879 33.5781,33.1879 C32.1105,33.1879 30.921,29.5191 30.921,25.005 C30.921,20.4908 32.1105,16.8223 33.5781,16.8223 C35.0457,16.8223 36.2352,20.4908 36.2352,25.005 z"
                },
                Ports = port
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "XorGate",
                Shape = new
                {
                    type = "Path",
                    data = "M21.7,76.5L21.7,76.5c6.4-18.1,6.4-37.8,0-55.9l0-0.1h1.6c21.5,0,41.7,10.4,54.2,28l0,0l0,0  c-12.5,17.6-32.7,28-54.2,28H21.7z M73.4,48.5L73.4,48.5 M17.5,76.8L17.5,76.8c6.7-18.2,6.7-38.1,0-56.3l0-0.1 M77.5,48.5h22   M0,32.5h21 M0,65.5h21"
                },
                Ports = orPort
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "ChEmitter",
                Shape = new
                {
                    type = "Path",
                    data = "M75.5,49.5l-52,28v-56L75.5,49.5z M75.5,49.5h24 M1.5,49.5h22 M44.5,45.5h-5v8h5V45.5z M39.5,45.5h10   M34.5,53.5h10"
                },
                Ports = orPort
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "NandGate",
                Shape = new
                {
                    type = "Path",
                    data = "M173.2472,549L173.2472,539 M173.2472,466L173.2472,456 M154.6192,523L145.2472,518.305L145.2472,527.695L154.6192,523z M191.2472,518L197.2472,518 M125.2472,523L145.2472,523 M125.2472,482L145.2472,482 M201.2472,523L221.2472,523 M201.2472,482L221.2472,482 M196.2262,523.597C196.2162,524.421,196.0452,525.053,195.7132,525.494C195.3812,525.935,194.9122,526.156,194.3072,526.156C193.7012,526.156,193.2282,525.921,192.8892,525.453C192.5482,524.984,192.3782,524.343,192.3782,523.529L192.3782,523.006C192.3882,522.206,192.5622,521.58,192.9022,521.129C193.2432,520.678,193.7082,520.453,194.2972,520.453C194.9152,520.453,195.3922,520.68,195.7252,521.134C196.0592,521.588,196.2262,522.233,196.2262,523.07L196.2262,523.597z M197.1632,523.075C197.1632,522.381,197.0462,521.775,196.8112,521.256C196.5772,520.737,196.2422,520.339,195.8092,520.062C195.3732,519.785,194.8702,519.647,194.2972,519.647C193.7372,519.647,193.2402,519.786,192.8052,520.064C192.3712,520.343,192.0342,520.744,191.7972,521.268C191.5592,521.792,191.4402,522.396,191.4402,523.08L191.4402,523.592C191.4472,524.263,191.5702,524.853,191.8092,525.362C192.0492,525.872,192.3852,526.264,192.8172,526.539C193.2502,526.814,193.7472,526.952,194.3072,526.952C194.5672,526.952,194.8142,526.922,195.0492,526.864L196.5482,528.055L197.1872,527.464L195.9182,526.468C196.3112,526.188,196.6182,525.8,196.8362,525.304C197.0542,524.807,197.1632,524.216,197.1632,523.529L197.1632,523.075z M174.1562,473.249C174.4002,473.439,174.5222,473.709,174.5222,474.057C174.5222,474.405,174.3912,474.681,174.1272,474.882C173.8632,475.084,173.4842,475.185,172.9892,475.185C172.4592,475.185,172.0352,475.061,171.7172,474.812C171.4002,474.562,171.2412,474.223,171.2412,473.793L170.2992,473.793C170.2992,474.207,170.4142,474.576,170.6432,474.902C170.8732,475.228,171.1992,475.484,171.6222,475.671C172.0452,475.858,172.5012,475.952,172.9892,475.952C173.7412,475.952,174.3422,475.778,174.7912,475.432C175.2402,475.085,175.4652,474.624,175.4652,474.047C175.4652,473.686,175.3852,473.372,175.2232,473.105C175.0622,472.838,174.8142,472.604,174.4802,472.404C174.1472,472.204,173.6852,472.021,173.0942,471.854C172.5042,471.688,172.0852,471.505,171.8402,471.304C171.5942,471.104,171.4712,470.858,171.4712,470.568C171.4712,470.206,171.6002,469.923,171.8592,469.719C172.1172,469.516,172.4782,469.414,172.9402,469.414C173.4382,469.414,173.8242,469.537,174.0982,469.784C174.3712,470.03,174.5082,470.369,174.5082,470.8L175.4502,470.8C175.4502,470.406,175.3462,470.043,175.1352,469.711C174.9262,469.379,174.6292,469.119,174.2462,468.93C173.8642,468.741,173.4292,468.647,172.9402,468.647C172.2252,468.647,171.6432,468.83,171.1952,469.196C170.7472,469.562,170.5232,470.025,170.5232,470.585C170.5232,471.08,170.7072,471.496,171.0722,471.833C171.4392,472.17,172.0242,472.454,172.8282,472.685C173.4702,472.871,173.9122,473.059,174.1562,473.249z M171.6712,528.511L173.1062,528.511C173.6012,528.515,173.9792,528.633,174.2422,528.868C174.5042,529.103,174.6352,529.44,174.6352,529.881C174.6352,530.285,174.4972,530.608,174.2232,530.85C173.9472,531.091,173.5772,531.211,173.1112,531.211L171.6712,531.211L171.6712,528.511z M174.8842,534.854L175.8902,534.854L175.8902,534.795L174.2202,531.778C174.6462,531.615,174.9782,531.369,175.2192,531.041C175.4572,530.712,175.5772,530.326,175.5772,529.883C175.5772,529.187,175.3612,528.656,174.9302,528.292C174.4992,527.927,173.8832,527.745,173.0822,527.745L170.7282,527.745L170.7282,534.854L171.6712,534.854L171.6712,531.978L173.3412,531.978L174.8842,534.854z M196.2262,482.597C196.2162,483.421,196.0452,484.053,195.7132,484.494C195.3812,484.935,194.9122,485.156,194.3072,485.156C193.7012,485.156,193.2282,484.921,192.8892,484.453C192.5482,483.984,192.3782,483.343,192.3782,482.529L192.3782,482.006C192.3882,481.206,192.5622,480.58,192.9022,480.129C193.2432,479.678,193.7082,479.453,194.2972,479.453C194.9152,479.453,195.3922,479.68,195.7252,480.134C196.0592,480.588,196.2262,481.233,196.2262,482.07L196.2262,482.597z M197.1632,482.075C197.1632,481.381,197.0462,480.775,196.8112,480.256C196.5772,479.737,196.2422,479.339,195.8092,479.062C195.3732,478.785,194.8702,478.647,194.2972,478.647C193.7372,478.647,193.2402,478.786,192.8052,479.064C192.3712,479.343,192.0342,479.744,191.7972,480.268C191.5592,480.792,191.4402,481.396,191.4402,482.08L191.4402,482.592C191.4472,483.263,191.5702,483.853,191.8092,484.362C192.0492,484.872,192.3852,485.264,192.8172,485.539C193.2502,485.814,193.7472,485.952,194.3072,485.952C194.5672,485.952,194.8142,485.922,195.0492,485.864L196.5482,487.055L197.1872,486.464L195.9182,485.468C196.3112,485.188,196.6182,484.8,196.8362,484.304C197.0542,483.807,197.1632,483.216,197.1632,482.529L197.1632,482.075z M173.0302,499.315C174.0512,499.315,174.8302,499.641,175.3662,500.29C175.9022,500.94,176.1712,501.881,176.1712,503.113L176.1712,503.745C176.1602,504.956,175.8782,505.885,175.3232,506.532C174.7682,507.179,173.9732,507.503,172.9362,507.503L171.6472,507.503L171.6472,499.315L173.0302,499.315z M172.9442,509.097C173.9712,509.097,174.8812,508.875,175.6752,508.433C176.4692,507.99,177.0812,507.36,177.5112,506.542C177.9402,505.725,178.1552,504.776,178.1552,503.698L178.1552,503.128C178.1552,502.065,177.9412,501.123,177.5152,500.3C177.0882,499.477,176.4842,498.842,175.7062,498.394C174.9282,497.946,174.0352,497.722,173.0302,497.722L169.6712,497.722L169.6712,509.097L172.9442,509.097z M150.7652,479.511C151.4612,479.518,151.9992,479.745,152.3792,480.193C152.7582,480.641,152.9472,481.269,152.9472,482.077L152.9472,482.492C152.9472,483.323,152.7462,483.963,152.3442,484.413C151.9422,484.863,151.3802,485.087,150.6572,485.087L149.6712,485.087L149.6712,479.511L150.7652,479.511z M150.7012,485.854C151.3392,485.848,151.8982,485.709,152.3792,485.439C152.8582,485.169,153.2282,484.781,153.4862,484.277C153.7462,483.772,153.8752,483.185,153.8752,482.514L153.8752,482.06C153.8722,481.406,153.7402,480.826,153.4822,480.322C153.2232,479.817,152.8562,479.428,152.3812,479.155C151.9052,478.881,151.3582,478.745,150.7402,478.745L148.7332,478.745L148.7332,485.854L150.7012,485.854z M145.2382,466L201.2552,466L201.2552,539L145.2382,539z"
                },
                Ports = jkPorts
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "Flipflop",
                Shape = new
                {
                    type = "Path",
                    data = "M21.5,13.5h57v73h-57V13.5z M29.8,26.2h-5.4V27h2.2v6.4h0.9V27h2.2V26.2z M54.2,45.2h-9v1.5h3.5v9.9h1.9v-9.9  h3.6V45.2z M74.5,29.2c0-0.9-0.3-1.6-0.8-2.2c-0.5-0.6-1.2-0.9-2.1-0.9c-0.8,0-1.5,0.3-2,0.9s-0.8,1.3-0.8,2.2v1.3  c0,0.9,0.3,1.6,0.8,2.2s1.2,0.9,2,0.9c0.2,0,0.3,0,0.5,0c0.2,0,0.3-0.1,0.5-0.1l1.3,1.2l0.6-0.6l-1.2-1.1c0.4-0.3,0.7-0.6,0.9-1.1  s0.3-0.9,0.3-1.4V29.2z M73.6,30.4c0,0.7-0.2,1.2-0.5,1.6c-0.4,0.4-0.8,0.6-1.5,0.6c-0.6,0-1-0.2-1.4-0.6c-0.3-0.4-0.5-1-0.5-1.6  v-1.3c0-0.7,0.2-1.2,0.5-1.6c0.3-0.4,0.8-0.6,1.4-0.6c0.6,0,1.1,0.2,1.5,0.6s0.5,1,0.5,1.6V30.4z M74.5,70.2c0-0.9-0.3-1.6-0.8-2.2  c-0.5-0.6-1.2-0.9-2.1-0.9c-0.8,0-1.5,0.3-2,0.9s-0.8,1.3-0.8,2.2v1.3c0,0.9,0.3,1.6,0.8,2.2s1.2,0.9,2,0.9c0.2,0,0.3,0,0.5,0  c0.2,0,0.3-0.1,0.5-0.1l1.3,1.2l0.6-0.6l-1.2-1.1c0.4-0.3,0.7-0.6,0.9-1.1s0.3-0.9,0.3-1.4V70.2z M73.6,71.4c0,0.7-0.2,1.2-0.5,1.6  c-0.4,0.4-0.8,0.6-1.5,0.6c-0.6,0-1-0.2-1.4-0.6c-0.3-0.4-0.5-1-0.5-1.6v-1.3c0-0.7,0.2-1.2,0.5-1.6c0.3-0.4,0.8-0.6,1.4-0.6  c0.6,0,1.1,0.2,1.5,0.6s0.5,1,0.5,1.6V71.4z M78.5,29.5h20 M78.5,70.5h20 M1.5,29.5h20 M1.5,70.5h20 M68.5,65.5h6 M31.5,70.5l-10-5  v10L31.5,70.5z"
                },
                Ports = flipPorts
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "RSLatch",
                Shape = new
                {
                    type = "Path",
                    data = "M21.5,11.5h57v73h-57V11.5z M28.5,30.4c-0.3,0.2-0.7,0.3-1.2,0.3c-0.5,0-0.9-0.1-1.3-0.4  c-0.3-0.2-0.5-0.6-0.5-1.1h-0.9c0,0.7,0.3,1.2,0.8,1.6c0.5,0.4,1.2,0.6,1.9,0.6c0.8,0,1.4-0.2,1.8-0.5c0.5-0.3,0.7-0.8,0.7-1.4  c0-0.5-0.2-1-0.6-1.3c-0.4-0.4-1-0.6-1.7-0.8c-0.7-0.2-1.1-0.3-1.4-0.5c-0.3-0.2-0.4-0.5-0.4-0.8c0-0.4,0.1-0.6,0.4-0.9  s0.6-0.3,1.1-0.3c0.5,0,0.9,0.1,1.2,0.4s0.4,0.6,0.4,1h0.9c0-0.6-0.2-1.1-0.7-1.5s-1.1-0.6-1.9-0.6c-0.7,0-1.3,0.2-1.8,0.5  c-0.4,0.4-0.7,0.8-0.7,1.4c0,0.5,0.2,1,0.6,1.3s1,0.6,1.8,0.8c0.6,0.2,1.1,0.3,1.3,0.6s0.4,0.5,0.4,0.8  C28.9,29.9,28.8,30.2,28.5,30.4z M27.7,69.3c0.4,0,0.7,0.1,0.9,0.3s0.3,0.5,0.3,0.9v0.6c0,0.2,0,0.4,0.1,0.7s0.1,0.4,0.2,0.5h0.9  v-0.1c-0.1-0.1-0.2-0.3-0.3-0.4s-0.1-0.4-0.1-0.6v-0.7c0-0.4-0.1-0.8-0.3-1.1c-0.2-0.3-0.5-0.5-0.9-0.6c0.4-0.2,0.7-0.4,0.9-0.6  c0.2-0.3,0.3-0.6,0.3-1c0-0.7-0.2-1.2-0.6-1.5c-0.4-0.3-1-0.5-1.8-0.5H25v7.1h0.9v-3.1H27.7z M25.9,66h1.6c0.5,0,0.9,0.1,1.1,0.3  s0.4,0.5,0.4,0.9c0,0.4-0.1,0.8-0.4,1c-0.2,0.2-0.6,0.3-1.2,0.3h-1.6V66z M49.5,54.6c1.6,0,2.9-0.4,3.8-1.3c0.9-0.9,1.4-2.1,1.4-3.6  v-1.5c0-1.5-0.5-2.7-1.4-3.6c-0.9-0.9-2.1-1.4-3.7-1.4H46v11.4H49.5z M49.5,44.7c1.1,0,1.9,0.3,2.4,0.9c0.5,0.6,0.8,1.4,0.8,2.5v1.5  c0,1.1-0.3,1.9-0.8,2.5s-1.4,0.9-2.5,0.9h-1.5v-8.3H49.5z M74.5,27.2c0-0.9-0.3-1.6-0.8-2.2c-0.5-0.6-1.2-0.9-2.1-0.9  c-0.8,0-1.5,0.3-2,0.9s-0.8,1.3-0.8,2.2v1.3c0,0.9,0.3,1.6,0.8,2.2s1.2,0.9,2,0.9c0.2,0,0.3,0,0.5,0c0.2,0,0.3-0.1,0.5-0.1l1.3,1.2  l0.6-0.6l-1.2-1.1c0.4-0.3,0.7-0.6,0.9-1.1s0.3-0.9,0.3-1.4V27.2z M73.6,28.4c0,0.7-0.2,1.2-0.5,1.6c-0.4,0.4-0.8,0.6-1.5,0.6  c-0.6,0-1-0.2-1.4-0.6c-0.3-0.4-0.5-1-0.5-1.6v-1.3c0-0.7,0.2-1.2,0.5-1.6c0.3-0.4,0.8-0.6,1.4-0.6c0.6,0,1.1,0.2,1.5,0.6  s0.5,1,0.5,1.6V28.4z M74.5,68.2c0-0.9-0.3-1.6-0.8-2.2c-0.5-0.6-1.2-0.9-2.1-0.9c-0.8,0-1.5,0.3-2,0.9s-0.8,1.3-0.8,2.2v1.3  c0,0.9,0.3,1.6,0.8,2.2s1.2,0.9,2,0.9c0.2,0,0.3,0,0.5,0c0.2,0,0.3-0.1,0.5-0.1l1.3,1.2l0.6-0.6l-1.2-1.1c0.4-0.3,0.7-0.6,0.9-1.1  s0.3-0.9,0.3-1.4V68.2z M73.6,69.4c0,0.7-0.2,1.2-0.5,1.6c-0.4,0.4-0.8,0.6-1.5,0.6c-0.6,0-1-0.2-1.4-0.6c-0.3-0.4-0.5-1-0.5-1.6  v-1.3c0-0.7,0.2-1.2,0.5-1.6c0.3-0.4,0.8-0.6,1.4-0.6c0.6,0,1.1,0.2,1.5,0.6s0.5,1,0.5,1.6V69.4z M78.5,27.5h20 M78.5,68.5h20   M1.5,27.5h20 M1.5,68.5h20 M68.5,63.5h6"
                },
                Ports = flipPorts
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "RSLatchSync",
                Shape = new
                {
                    type = "Path",
                    data = "M173.2472,549L173.2472,539 M173.2472,466L173.2472,456 M154.6192,523L145.2472,518.305L145.2472,527.695L154.6192,523z M191.2472,518L197.2472,518 M125.2472,523L145.2472,523 M125.2472,482L145.2472,482 M201.2472,523L221.2472,523 M201.2472,482L221.2472,482 M196.2262,523.597C196.2162,524.421,196.0452,525.053,195.7132,525.494C195.3812,525.935,194.9122,526.156,194.3072,526.156C193.7012,526.156,193.2282,525.921,192.8892,525.453C192.5482,524.984,192.3782,524.343,192.3782,523.529L192.3782,523.006C192.3882,522.206,192.5622,521.58,192.9022,521.129C193.2432,520.678,193.7082,520.453,194.2972,520.453C194.9152,520.453,195.3922,520.68,195.7252,521.134C196.0592,521.588,196.2262,522.233,196.2262,523.07L196.2262,523.597z M197.1632,523.075C197.1632,522.381,197.0462,521.775,196.8112,521.256C196.5772,520.737,196.2422,520.339,195.8092,520.062C195.3732,519.785,194.8702,519.647,194.2972,519.647C193.7372,519.647,193.2402,519.786,192.8052,520.064C192.3712,520.343,192.0342,520.744,191.7972,521.268C191.5592,521.792,191.4402,522.396,191.4402,523.08L191.4402,523.592C191.4472,524.263,191.5702,524.853,191.8092,525.362C192.0492,525.872,192.3852,526.264,192.8172,526.539C193.2502,526.814,193.7472,526.952,194.3072,526.952C194.5672,526.952,194.8142,526.922,195.0492,526.864L196.5482,528.055L197.1872,527.464L195.9182,526.468C196.3112,526.188,196.6182,525.8,196.8362,525.304C197.0542,524.807,197.1632,524.216,197.1632,523.529L197.1632,523.075z M174.1562,473.249C174.4002,473.439,174.5222,473.709,174.5222,474.057C174.5222,474.405,174.3912,474.681,174.1272,474.882C173.8632,475.084,173.4842,475.185,172.9892,475.185C172.4592,475.185,172.0352,475.061,171.7172,474.812C171.4002,474.562,171.2412,474.223,171.2412,473.793L170.2992,473.793C170.2992,474.207,170.4142,474.576,170.6432,474.902C170.8732,475.228,171.1992,475.484,171.6222,475.671C172.0452,475.858,172.5012,475.952,172.9892,475.952C173.7412,475.952,174.3422,475.778,174.7912,475.432C175.2402,475.085,175.4652,474.624,175.4652,474.047C175.4652,473.686,175.3852,473.372,175.2232,473.105C175.0622,472.838,174.8142,472.604,174.4802,472.404C174.1472,472.204,173.6852,472.021,173.0942,471.854C172.5042,471.688,172.0852,471.505,171.8402,471.304C171.5942,471.104,171.4712,470.858,171.4712,470.568C171.4712,470.206,171.6002,469.923,171.8592,469.719C172.1172,469.516,172.4782,469.414,172.9402,469.414C173.4382,469.414,173.8242,469.537,174.0982,469.784C174.3712,470.03,174.5082,470.369,174.5082,470.8L175.4502,470.8C175.4502,470.406,175.3462,470.043,175.1352,469.711C174.9262,469.379,174.6292,469.119,174.2462,468.93C173.8642,468.741,173.4292,468.647,172.9402,468.647C172.2252,468.647,171.6432,468.83,171.1952,469.196C170.7472,469.562,170.5232,470.025,170.5232,470.585C170.5232,471.08,170.7072,471.496,171.0722,471.833C171.4392,472.17,172.0242,472.454,172.8282,472.685C173.4702,472.871,173.9122,473.059,174.1562,473.249z M171.6712,528.511L173.1062,528.511C173.6012,528.515,173.9792,528.633,174.2422,528.868C174.5042,529.103,174.6352,529.44,174.6352,529.881C174.6352,530.285,174.4972,530.608,174.2232,530.85C173.9472,531.091,173.5772,531.211,173.1112,531.211L171.6712,531.211L171.6712,528.511z M174.8842,534.854L175.8902,534.854L175.8902,534.795L174.2202,531.778C174.6462,531.615,174.9782,531.369,175.2192,531.041C175.4572,530.712,175.5772,530.326,175.5772,529.883C175.5772,529.187,175.3612,528.656,174.9302,528.292C174.4992,527.927,173.8832,527.745,173.0822,527.745L170.7282,527.745L170.7282,534.854L171.6712,534.854L171.6712,531.978L173.3412,531.978L174.8842,534.854z M196.2262,482.597C196.2162,483.421,196.0452,484.053,195.7132,484.494C195.3812,484.935,194.9122,485.156,194.3072,485.156C193.7012,485.156,193.2282,484.921,192.8892,484.453C192.5482,483.984,192.3782,483.343,192.3782,482.529L192.3782,482.006C192.3882,481.206,192.5622,480.58,192.9022,480.129C193.2432,479.678,193.7082,479.453,194.2972,479.453C194.9152,479.453,195.3922,479.68,195.7252,480.134C196.0592,480.588,196.2262,481.233,196.2262,482.07L196.2262,482.597z M197.1632,482.075C197.1632,481.381,197.0462,480.775,196.8112,480.256C196.5772,479.737,196.2422,479.339,195.8092,479.062C195.3732,478.785,194.8702,478.647,194.2972,478.647C193.7372,478.647,193.2402,478.786,192.8052,479.064C192.3712,479.343,192.0342,479.744,191.7972,480.268C191.5592,480.792,191.4402,481.396,191.4402,482.08L191.4402,482.592C191.4472,483.263,191.5702,483.853,191.8092,484.362C192.0492,484.872,192.3852,485.264,192.8172,485.539C193.2502,485.814,193.7472,485.952,194.3072,485.952C194.5672,485.952,194.8142,485.922,195.0492,485.864L196.5482,487.055L197.1872,486.464L195.9182,485.468C196.3112,485.188,196.6182,484.8,196.8362,484.304C197.0542,483.807,197.1632,483.216,197.1632,482.529L197.1632,482.075z M173.0302,499.315C174.0512,499.315,174.8302,499.641,175.3662,500.29C175.9022,500.94,176.1712,501.881,176.1712,503.113L176.1712,503.745C176.1602,504.956,175.8782,505.885,175.3232,506.532C174.7682,507.179,173.9732,507.503,172.9362,507.503L171.6472,507.503L171.6472,499.315L173.0302,499.315z M172.9442,509.097C173.9712,509.097,174.8812,508.875,175.6752,508.433C176.4692,507.99,177.0812,507.36,177.5112,506.542C177.9402,505.725,178.1552,504.776,178.1552,503.698L178.1552,503.128C178.1552,502.065,177.9412,501.123,177.5152,500.3C177.0882,499.477,176.4842,498.842,175.7062,498.394C174.9282,497.946,174.0352,497.722,173.0302,497.722L169.6712,497.722L169.6712,509.097L172.9442,509.097z M150.7652,479.511C151.4612,479.518,151.9992,479.745,152.3792,480.193C152.7582,480.641,152.9472,481.269,152.9472,482.077L152.9472,482.492C152.9472,483.323,152.7462,483.963,152.3442,484.413C151.9422,484.863,151.3802,485.087,150.6572,485.087L149.6712,485.087L149.6712,479.511L150.7652,479.511z M150.7012,485.854C151.3392,485.848,151.8982,485.709,152.3792,485.439C152.8582,485.169,153.2282,484.781,153.4862,484.277C153.7462,483.772,153.8752,483.185,153.8752,482.514L153.8752,482.06C153.8722,481.406,153.7402,480.826,153.4822,480.322C153.2232,479.817,152.8562,479.428,152.3812,479.155C151.9052,478.881,151.3582,478.745,150.7402,478.745L148.7332,478.745L148.7332,485.854L150.7012,485.854z M145.2382,466L201.2552,466L201.2552,539L145.2382,539z"
                },
                Ports = jkPorts
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "JKflipflop",
                Shape = new
                {
                    type = "Path",
                    data = "M22.5,14.5h56v72h-56V14.5z M28.9,31.4c0,0.4-0.1,0.7-0.3,1s-0.5,0.4-0.9,0.4c-0.4,0-0.8-0.1-1-0.3  s-0.3-0.6-0.3-1h-0.9c0,0.7,0.2,1.2,0.6,1.5c0.4,0.3,0.9,0.5,1.6,0.5c0.6,0,1.2-0.2,1.6-0.5s0.6-0.9,0.6-1.5v-5.1h-0.9V31.4z   M30.4,73.4h1.1l-3-3.7l2.8-3.4h-1l-2.6,3.2H27v-3.2H26v7.1H27v-3.2h0.9L30.4,73.4z M74.5,29.2c0-0.9-0.3-1.6-0.8-2.2  c-0.5-0.6-1.2-0.9-2.1-0.9c-0.8,0-1.5,0.3-2,0.9s-0.8,1.3-0.8,2.2v1.3c0,0.9,0.3,1.6,0.8,2.2s1.2,0.9,2,0.9c0.2,0,0.3,0,0.5,0  c0.2,0,0.3-0.1,0.5-0.1l1.3,1.2l0.6-0.6l-1.2-1.1c0.4-0.3,0.7-0.6,0.9-1.1s0.3-0.9,0.3-1.4V29.2z M73.6,30.4c0,0.7-0.2,1.2-0.5,1.6  c-0.4,0.4-0.8,0.6-1.5,0.6c-0.6,0-1-0.2-1.4-0.6c-0.3-0.4-0.5-1-0.5-1.6v-1.3c0-0.7,0.2-1.2,0.5-1.6c0.3-0.4,0.8-0.6,1.4-0.6  c0.6,0,1.1,0.2,1.5,0.6s0.5,1,0.5,1.6V30.4z M74.5,70.2c0-0.9-0.3-1.6-0.8-2.2c-0.5-0.6-1.2-0.9-2.1-0.9c-0.8,0-1.5,0.3-2,0.9  s-0.8,1.3-0.8,2.2v1.3c0,0.9,0.3,1.6,0.8,2.2s1.2,0.9,2,0.9c0.2,0,0.3,0,0.5,0c0.2,0,0.3-0.1,0.5-0.1l1.3,1.2l0.6-0.6l-1.2-1.1  c0.4-0.3,0.7-0.6,0.9-1.1s0.3-0.9,0.3-1.4V70.2z M73.6,71.4c0,0.7-0.2,1.2-0.5,1.6c-0.4,0.4-0.8,0.6-1.5,0.6c-0.6,0-1-0.2-1.4-0.6  c-0.3-0.4-0.5-1-0.5-1.6v-1.3c0-0.7,0.2-1.2,0.5-1.6c0.3-0.4,0.8-0.6,1.4-0.6c0.6,0,1.1,0.2,1.5,0.6s0.5,1,0.5,1.6V71.4z M50.7,80.3  c0.4,0,0.7,0.1,0.9,0.3s0.3,0.5,0.3,0.9v0.6c0,0.2,0,0.4,0.1,0.7s0.1,0.4,0.2,0.5h0.9v-0.1c-0.1-0.1-0.2-0.3-0.3-0.4  s-0.1-0.4-0.1-0.6v-0.7c0-0.4-0.1-0.8-0.3-1.1c-0.2-0.3-0.5-0.5-0.9-0.6c0.4-0.2,0.7-0.4,0.9-0.6c0.2-0.3,0.3-0.6,0.3-1  c0-0.7-0.2-1.2-0.6-1.5c-0.4-0.3-1-0.5-1.8-0.5H48v7.1h0.9v-3.1H50.7z M48.9,77h1.6c0.5,0,0.9,0.1,1.1,0.3s0.4,0.5,0.4,0.9  c0,0.4-0.1,0.8-0.4,1c-0.2,0.2-0.6,0.3-1.2,0.3h-1.6V77z M51.5,23.4c-0.3,0.2-0.7,0.3-1.2,0.3c-0.5,0-0.9-0.1-1.3-0.4  c-0.3-0.2-0.5-0.6-0.5-1.1h-0.9c0,0.7,0.3,1.2,0.8,1.6c0.5,0.4,1.2,0.6,1.9,0.6c0.8,0,1.4-0.2,1.8-0.5c0.5-0.3,0.7-0.8,0.7-1.4  c0-0.5-0.2-1-0.6-1.3c-0.4-0.4-1-0.6-1.7-0.8c-0.7-0.2-1.1-0.3-1.4-0.5c-0.3-0.2-0.4-0.5-0.4-0.8c0-0.4,0.1-0.6,0.4-0.9  s0.6-0.3,1.1-0.3c0.5,0,0.9,0.1,1.2,0.4s0.4,0.6,0.4,1h0.9c0-0.6-0.2-1.1-0.7-1.5s-1.1-0.6-1.9-0.6c-0.7,0-1.3,0.2-1.8,0.5  c-0.4,0.4-0.7,0.8-0.7,1.4c0,0.5,0.2,1,0.6,1.3s1,0.6,1.8,0.8c0.6,0.2,1.1,0.3,1.3,0.6s0.4,0.5,0.4,0.8  C51.9,22.9,51.8,23.2,51.5,23.4z M78.5,29.5h20 M78.5,70.5h20 M2.5,29.5h20 M2.5,70.5h20 M68.5,65.5h6 M2.5,50.5h20 M31.9,51.5  l-9.4-4.7v9.4L31.9,51.5z M50.5,14.5v-10 M50.5,96.5v-10"
                },
                Ports = jkPorts
            });
            LogigGates.Add(new DiagramNode()
            {
                Id = "Dflipflop",
                Shape = new
                {
                    type = "Path",
                    data = "M21.2,13.5h57v73h-57V13.5z M78.2,29.5h20 M78.2,70.5h20 M1.2,29.5h20 M1.2,70.5h20 M26.6,33.4  c0.6,0,1.2-0.1,1.7-0.4c0.5-0.3,0.8-0.7,1.1-1.2c0.3-0.5,0.4-1.1,0.4-1.8v-0.5c0-0.7-0.1-1.2-0.4-1.7c-0.3-0.5-0.6-0.9-1.1-1.2  s-1-0.4-1.6-0.4h-2v7.1H26.6z M26.7,27c0.7,0,1.2,0.2,1.6,0.7c0.4,0.4,0.6,1.1,0.6,1.9V30c0,0.8-0.2,1.5-0.6,1.9  c-0.4,0.4-1,0.7-1.7,0.7h-1V27H26.7z M48.9,56.6c1,0,1.9-0.2,2.7-0.7c0.8-0.4,1.4-1.1,1.8-1.9c0.4-0.8,0.6-1.8,0.6-2.8v-0.6  c0-1.1-0.2-2-0.6-2.8c-0.4-0.8-1-1.5-1.8-1.9c-0.8-0.4-1.7-0.7-2.7-0.7h-3.4v11.4H48.9z M48.9,46.8c1,0,1.8,0.3,2.3,1  c0.5,0.7,0.8,1.6,0.8,2.8v0.6c0,1.2-0.3,2.1-0.8,2.8s-1.4,1-2.4,1h-1.3v-8.2H48.9z M74.1,29.6c0-0.7-0.1-1.3-0.4-1.8s-0.6-0.9-1-1.2  c-0.4-0.3-0.9-0.4-1.5-0.4c-0.6,0-1.1,0.1-1.5,0.4c-0.4,0.3-0.8,0.7-1,1.2s-0.4,1.1-0.4,1.8v0.5c0,0.7,0.1,1.3,0.4,1.8  c0.2,0.5,0.6,0.9,1,1.2s0.9,0.4,1.5,0.4c0.3,0,0.5,0,0.7-0.1l1.5,1.2l0.6-0.6l-1.3-1c0.4-0.3,0.7-0.7,0.9-1.2s0.3-1.1,0.3-1.8V29.6z   M73.1,30.1c0,0.8-0.2,1.5-0.5,1.9s-0.8,0.7-1.4,0.7s-1.1-0.2-1.4-0.7c-0.3-0.5-0.5-1.1-0.5-1.9v-0.5c0-0.8,0.2-1.4,0.5-1.9  c0.3-0.5,0.8-0.7,1.4-0.7c0.6,0,1.1,0.2,1.4,0.7c0.3,0.5,0.5,1.1,0.5,1.9V30.1z M74.1,70.6c0-0.7-0.1-1.3-0.4-1.8s-0.6-0.9-1-1.2  c-0.4-0.3-0.9-0.4-1.5-0.4c-0.6,0-1.1,0.1-1.5,0.4c-0.4,0.3-0.8,0.7-1,1.2s-0.4,1.1-0.4,1.8v0.5c0,0.7,0.1,1.3,0.4,1.8  c0.2,0.5,0.6,0.9,1,1.2s0.9,0.4,1.5,0.4c0.3,0,0.5,0,0.7-0.1l1.5,1.2l0.6-0.6l-1.3-1c0.4-0.3,0.7-0.7,0.9-1.2s0.3-1.1,0.3-1.8V70.6z   M73.1,71.1c0,0.8-0.2,1.5-0.5,1.9s-0.8,0.7-1.4,0.7s-1.1-0.2-1.4-0.7c-0.3-0.5-0.5-1.1-0.5-1.9v-0.5c0-0.8,0.2-1.4,0.5-1.9  c0.3-0.5,0.8-0.7,1.4-0.7c0.6,0,1.1,0.2,1.4,0.7c0.3,0.5,0.5,1.1,0.5,1.9V71.1z M68.2,65.5h6 M31.2,70.5l-10-5v10L31.2,70.5z"
                },
                Ports = flipPorts
            });


            List<Syncfusion.EJ2.Diagrams.DiagramConnector> PaletteLines = new List<Syncfusion.EJ2.Diagrams.DiagramConnector>();
            PaletteLines.Add(new DiagramConnector()
            {
                Id = "Link1",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 60, Y = 60 },
                TargetDecorator = new DiagramDecorator { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 1, StrokeColor = "#757575" }
            });
            PaletteLines.Add(new DiagramConnector()
            {
                Id = "Link11",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 60, Y = 60 },
                TargetDecorator = new DiagramDecorator { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 1, StrokeColor = "#757575", StrokeDashArray = "5,5" }
            });
            PaletteLines.Add(new DiagramConnector()
            {
                Id = "Link21",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 60, Y = 60 },
                TargetDecorator = new DiagramDecorator { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 1, StrokeColor = "#757575" }
            });
            PaletteLines.Add(new DiagramConnector()
            {
                Id = "Link22",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 60, Y = 60 },
                TargetDecorator = new DiagramDecorator { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 1, StrokeColor = "#757575", StrokeDashArray = "5,5" }
            });
            PaletteLines.Add(new DiagramConnector()
            {
                Id = "Link3",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 60, Y = 60 },
                CornerRadius = 5,
                TargetDecorator = new DiagramDecorator { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 1, StrokeColor = "#757575" }
            });
            PaletteLines.Add(new DiagramConnector()
            {
                Id = "Link31",
                Type = Segments.Orthogonal,
                CornerRadius = 5,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 60, Y = 60 },
                TargetDecorator = new DiagramDecorator { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 1, StrokeColor = "#757575", StrokeDashArray = "5,5" }
            });

            List<SymbolPalettePalette> Palette = new List<SymbolPalettePalette>();
            Palette.Add(new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = LogigGates, IconCss = "shapes", Title = "Flow Shapes" });
            Palette.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = true, Symbols = PaletteLines, IconCss = "shapes", Title = "Connectors" });

            ViewBag.Palette = Palette;


            DiagramSnapSettings snapSettings = new DiagramSnapSettings();
            snapSettings.Constraints = SnapConstraints.All & ~SnapConstraints.ShowLines;
            ViewBag.SnapSettings = snapSettings;

            DiagramConstraints constraints = DiagramConstraints.Default | DiagramConstraints.Bridging;
            ViewBag.Constraints = constraints;
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            ViewBag.getSymbolInfo = "getSymbolInfo";
            ViewBag.getSymbolDefaults = "getSymbolDefaults";
            return View();
        }

        // Create nodes as logic gates
        private DiagramNode CreateNode(string id, double offsetX, double offsetY, double height, double width, string pathData, List<DiagramPort> ports)
        {
            // update node properties
            DiagramNode node = new DiagramNode();
            node.Id = id;
            node.OffsetX = offsetX;
            node.OffsetY = offsetY - 30;
            node.Height = height;
            node.Width = width;
            node.Shape = new { type = "Path", data = pathData };
            node.Ports = ports;
            return node;
        }


        // Create Connectors to connect two logic gates
        private DiagramConnector createConnector(string id, DiagramPoint sourcePoint, DiagramPoint targetPoint, string sourceID, string targetID, string sourcePortID, string targetPortID, DiagramDecorator sourceDecorator, DiagramDecorator targetDecorator, DiagramConnectorAnnotation annotation, bool? segments, bool? isStraight)
        {
            // update connector properties
            DiagramConnector connector = new DiagramConnector();

            connector.Id = id;
            if(sourcePoint != null)
            {
                sourcePoint.Y = sourcePoint.Y - 30;
                connector.SourcePoint = sourcePoint;
            }
            if(targetPoint != null)
            {
                targetPoint.Y = targetPoint.Y - 30;
                connector.TargetPoint = targetPoint;
            } 
            
            connector.SourceID = sourceID;
            connector.TargetID = targetID;
            connector.Type = (isStraight == true) ? Segments.Straight : Segments.Orthogonal;
            connector.SourcePortID = sourcePortID;
            connector.TargetPortID = targetPortID;
            // update connector annotation properties
            connector.Annotations = new List<DiagramConnectorAnnotation>();
            connector.Annotations.Add(new DiagramConnectorAnnotation
            {
                Content = (annotation != null) ? annotation.Content : "",
                Offset = 0,
                Margin = new DiagramMargin()
                {
                    Left = (annotation != null && annotation.Margin != null) ? annotation.Margin.Left : 0,
                    Top = (annotation != null && annotation.Margin != null) ? annotation.Margin.Top : 0,
                },
                Style = new DiagramTextStyle()
                {
                    Bold = true,
                    FontFamily = "Segoe UI",
                    TextWrapping = TextWrap.NoWrap,
                    FontSize = 14
                }
            });
            // update connector decorators
            connector.SourceDecorator = sourceDecorator;
            connector.TargetDecorator = targetDecorator;
            // update connector segments
            if (segments == true)
            {
                 
                List<DiagramSegment> segmentLists = new List<DiagramSegment>();
                segmentLists.Add(new DiagramSegment() { Type = "Orthogonal", Length = 100, Direction = "Right" });
                connector.Segments = segmentLists;
            }
            return connector;
        }
    }

    public class DiagramSegment
    {
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("length")]
        [JsonProperty("length")]
        public double Length
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("direction")]
        [JsonProperty("direction")]
        public string Direction
        {
            get;
            set;
        }
    }

}
