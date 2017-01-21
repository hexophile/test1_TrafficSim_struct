using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.interfaces;
using test1_TrafficSim_struct.data;
using test1_TrafficSim_struct.src;

namespace test1_TrafficSim_struct
{
    /// <summary>
    /// Area is a representation of road fragment (sections connected with nodes). There can be only one area at time, since there's no connection point for other areas.
    /// </summary>
    public class Area :ObjectInfo, MapObject
    {
        private static long count = 0;
        private LinkedList<Way> ways; // refactor to List<> TODO
        private Coordinates coords;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Area()
        {
            count++;
            name = "Default_Constructed_Area:"+count;
            ways = new LinkedList<Way>();
        }

        ~Area()
        {
            count--;
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
            Segment segment = new Segment();
            segment += new Lane(segment, Direction.Backward, 4);
            segment += new Lane(segment, Direction.Forward, 4);

            LinkedList<Node> nodes = new LinkedList<Node>();
            nodes.AddLast(new Node().SetFirstSegment(null).SetLastSegment(segment));
            nodes.AddLast(new Node().SetFirstSegment(segment).SetLastSegment(null));

            segment.SetFirstNode(nodes.First.Value);
            segment.SetLastNode(nodes.Last.Value);
            // TODO repair this...

            LinkedList<Segment> segmentList = new LinkedList<Segment>();
            segmentList.AddFirst(segment);

            for ( int i = 0; i < amount; i++)
            {
                this.ways.AddLast(new Way(segmentList, nodes)); // TODO
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
        /// 
        /// </summary>
        /// <returns></returns>
        public LinkedList<Way> GetWays()
        {
            return this.ways;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        public Way GetWay(int index)
        {
            LinkedListNode<Way> temp = this.ways.First;
            for(int i = 0; i < index; i++)
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
