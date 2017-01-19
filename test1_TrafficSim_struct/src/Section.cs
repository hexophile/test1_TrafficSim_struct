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
    /// Section class represents road between nodes. Each section has lanes.
    /// </summary>
    public class Section :ObjectInfo, MapObject
    {
        private LinkedList<Node> superiorNodes;
        private LinkedList<Lane> lanes;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Section()
        {
            superiorNodes = null;
            lanes = null;
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Section(LinkedList<Node> NODE)
        {
            superiorNodes = NODE;
            lanes = null;
        }

        /// <summary>
        /// Adds lane to the end of the lanes list.
        /// </summary>
        /// <param name="LANE">New lane</param>
        /// <returns>Section with additional lane</returns>
        public Section PushLane(Lane LANE)
        {
            lanes.AddLast(LANE);
            return this;
        }

        /// <summary>
        /// Adds new lane to the end of the lanes list, only "Way" is needed.
        /// </summary>
        /// <param name="WAY">The way of lane</param>
        /// <returns>Section with additional lane</returns>
        public Section AddLane(Way WAY)
        {
            Lane newLane = new Lane(this, WAY, 0);
            return PushLane(newLane);
        }

        /// <summary>
        /// Adds new lane to the end of the lanes list, only "Way" is needed.
        /// </summary>
        /// <param name="WAY">The way of lane</param>
        /// <param name="LENGTH">Amount of cells in lane</param>
        /// <returns>Section with additional lane</returns>
        public Section AddLane(Way WAY, int LENGTH)
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
        public static Section operator+(Section SECTION, Lane LANE)
        {
            return SECTION.PushLane(LANE);
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
