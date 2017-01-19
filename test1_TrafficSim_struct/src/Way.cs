using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.interfaces;
using test1_TrafficSim_struct.data;

namespace test1_TrafficSim_struct.src
{
    class Way :ObjectInfo, MapObject
    {
        private LinkedList<Section> sections;
        private LinkedList<Node> nodes;
        
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
