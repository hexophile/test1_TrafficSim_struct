using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.interfaces;
using test1_TrafficSim_struct.data;

namespace test1_TrafficSim_struct.src
{
    public class Way :ObjectInfo, MapObject
    {
        private static long count = 0;
        private LinkedList<Segment> segments;
        private LinkedList<Node> nodes;

        /// <summary>
        /// Restricted
        /// </summary>
        private Way()
        {
        }

        ~Way()
        {
            count--;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="segmentList"></param>
        /// <param name="nodesList"></param>
        public Way(LinkedList<Segment> segmentList, LinkedList<Node> nodesList)
        {
            count++;
            name = "User_defined_Way:" + count;
            segments = segmentList;
            nodes = nodesList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Segment GetSegmentAt(int index)
        {
            LinkedListNode<Segment> temp = this.segments.First;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp.Value;
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
