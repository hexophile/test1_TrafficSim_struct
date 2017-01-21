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
    /// Segment class represents road between nodes. Each section has lanes.
    /// </summary>
    public class Segment : ObjectInfo, MapObject
    {
        private static long count = 0;
        public Node[] superiorNodes;
        private LinkedList<Lane> lanes;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Segment()
        {
            name = "Default_constructed_Segment:" + count;
            superiorNodes = new Node[2];
            superiorNodes[0] = null;
            superiorNodes[1] = null;
            lanes = new LinkedList<Lane>();
        }

        ~Segment()
        {
            count--;
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Segment(Node[] nodes)
        {// TODO repair arrays
            name = "User_defined_Segment:" + count;
            superiorNodes = new Node[2];
            superiorNodes[0] = nodes[0];
            superiorNodes[1] = nodes[1];
            lanes = new LinkedList<Lane>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Segment SetFirstNode(Node node)
        {
            this.superiorNodes[0] = node;
            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Segment SetLastNode(Node node)
        {
            this.superiorNodes[1] = node;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Lane GetLaneAt(int index)
        {
            LinkedListNode<Lane> temp = this.lanes.First;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        /// <summary>
        /// Adds lane to the end of the lanes list.
        /// </summary>
        /// <param name="LANE">New lane</param>
        /// <returns>Segment with additional lane</returns>
        public Segment PushLane(Lane LANE)
        {
            lanes.AddLast(LANE);
            return this;
        }

        /// <summary>
        /// Adds new lane to the end of the lanes list, only "Direction" is needed.
        /// </summary>
        /// <param name="WAY">The way of lane</param>
        /// <returns>Segment with additional lane</returns>
        public Segment AddLane(Direction WAY)
        {
            Lane newLane = new Lane(this, WAY, 0);
            return PushLane(newLane);
        }

        /// <summary>
        /// Adds new lane to the end of the lanes list, only "Direction" is needed.
        /// </summary>
        /// <param name="WAY">The way of lane</param>
        /// <param name="LENGTH">Amount of cells in lane</param>
        /// <returns>Segment with additional lane</returns>
        public Segment AddLane(Direction WAY, int LENGTH)
        {
            Lane newLane = new Lane(this, WAY, LENGTH);
            return PushLane(newLane);
        }

        /// <summary>
        /// Operator that lets to add lanes by + operator
        /// </summary>
        /// <param name="SECTION"></param>
        /// <param name="LANE"></param>
        /// <returns>Surrent section</returns>
        public static Segment operator+(Segment SECTION, Lane LANE)
        {
            return SECTION.PushLane(LANE);
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
