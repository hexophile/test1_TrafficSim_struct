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
    /// Node class represents connection between two sections.
    /// </summary>
    public class Node :ObjectInfo, MapObject
    {
        private KeyValuePair<Section, Section> sections; // ?! TODO
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String GetStatus()
        {
            return "OK";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Coordinates GetCoordinates()
        {
            return this.coords;
        }
    }
}
