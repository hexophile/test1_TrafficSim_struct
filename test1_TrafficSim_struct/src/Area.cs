using System;
using System.Collections.Generic;
using System.Linq;
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

        static public Area Generate(List<KeyValuePair<KeyValuePair<int, bool>, int>> sections)
        {
            return new Area();
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
