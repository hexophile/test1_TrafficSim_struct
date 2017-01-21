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
        private static long count = 0;
        private Segment[] segments; // ?! TODO
        
        /// <summary>
        /// 
        /// </summary>
        public Node()
        {
            count++;
            name = "Default_constructed_Node:" + count;
            segments = new Segment[2];
            segments[0] = null;
            segments[1] = null;
        }

        /// <summary>
        /// 
        /// </summary>
        ~Node()
        {
            count--;
        }

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
        public Node SetFirstSegment(Segment segment)
        {
            this.segments[0] = segment;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Node SetLastSegment(Segment segment)
        {
            this.segments[1] = segment;
            return this;
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
