using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.interfaces;
using test1_TrafficSim_struct.data;

namespace test1_TrafficSim_struct
{
    /// <summary>
    /// Area is a representation of road fragment (sections connected with nodes). There can be only one area at time, since there's no connection point for other areas.
    /// </summary>
    public class Area :ObjectInfo, MapObject
    {
        private LinkedList<Way> ways;
        private Coordinates coords;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Area()
        {
            ways = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual String GetStatus()
        {
            return "OK";
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public Area GenerateWays(int amount)
        {
            for ( int i = 0; i < amount; i++)
            {
                this.ways.AddLast(new Way()); // TODO
            }

            return this;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="areaXML"></param>
        /// <returns></returns>
        static public Area Generate(XElement areaXML)
        {
            Area newArea = new Area();
            newArea.GenerateWays(2);
            return newArea;
        }

        /// <summary>
        /// Standard co-ordinates' getter
        /// </summary>
        /// <returns>Object's co-ordinates</returns>
        public Coordinates GetCoordinates()
        {
            return this.coords;
        }
    }
}
