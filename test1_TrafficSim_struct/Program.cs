using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1_TrafficSim_struct
{
    class Program
    {
        static int Main(string[] args)
        {
            RoadManagementEngine roadManagementEngine = RoadManagementEngine.GetInstance();

            /*
            XElement areaData =
                new XElement("AreaData",
                    new XElement("area1",
                        new XElement("Sections",
                            new XElement("Node", "node1"),
                            new XElement("section1",
                                new XElement("lane1", "left"),
                                new XElement("lane2", "right")
                            )
                        )
                    )
                ); // Gotta make nice XML generator
            Console.WriteLine(areaData);
            */
            
            
            //areaData
            //Area newArea = Area.Generate(areaData);

            roadManagementEngine.GenerateVisualisation();
            return roadManagementEngine.StartEngine();
            // But probably I'll finish up getting something like:
            // roadManagementEngine.Start().GetExitStatus();
            // And somewhere in the code there will be couple of Engine.Exit(<0; n>) etc.
        }
    }
}
