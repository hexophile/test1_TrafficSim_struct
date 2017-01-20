using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.interfaces;
using test1_TrafficSim_struct.data;

namespace test1_TrafficSim_struct.vehicles
{
    class Vehicle :ObjectInfo, LaneObject
    {
        protected Cell currentCell;
        protected Lane currentLane;
        protected Segment currentSegment;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Cell GetCell()
        {
            return this.currentCell;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Lane GetLane()
        {
            return this.currentLane;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Segment GetSegment()
        {
            return this.currentSegment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Coordinates GetCoordinates()
        {
            return this.coords;
        }
    }
}
