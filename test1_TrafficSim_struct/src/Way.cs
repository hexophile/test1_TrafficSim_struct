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
        private LinkedList<Segment> segments;
        private LinkedList<Node> nodes;

        /// <summary>
        /// Restricted
        /// </summary>
        private Way()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="segmentList"></param>
        /// <param name="nodesList"></param>
        public Way(LinkedList<Segment> segmentList, LinkedList<Node> nodesList)
        {
            segments = segmentList;
            nodes = nodesList;
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
