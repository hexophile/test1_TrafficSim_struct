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
    /// Class Cell represents single unit of lenght in Lanes.
    /// </summary>
    public class Cell : ObjectInfo, MapObject
    {
        private LaneObject content;
        private Lane superiorLane;
        private bool state;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LANE"></param>
        public Cell( Lane LANE )
        {
            superiorLane = LANE;
            state = false;
        }

        /// <summary>
        /// Function returns state of the cell
        /// </summary>
        /// <returns></returns>
        public bool IsFree()
        {
            return state;
        }


        /// <summary>
        /// Function returns content of the cell
        /// </summary>
        /// <returns></returns>
        public LaneObject GetContent()
        {
            return content;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="OBJECT">World object</param>
        /// <returns></returns>
        public Cell SetContent(LaneObject OBJECT) // ?!?!?!?! TODO
        {
            content = OBJECT;
            state = false;
            return this;
        }

        /// <summary>
        /// Sets content to null and state to free.
        /// </summary>
        /// <returns>Current cell</returns>
        public Cell Clear()
        {
            content = null;
            state = true;
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
