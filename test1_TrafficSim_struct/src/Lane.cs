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
    /// Each road has at least one lane, this class represents one of them. Each lane has its length, lanes are made of Cells.
    /// </summary>
    public class Lane : ObjectInfo, MapObject // Not sure about connections, should it be in Lane or Segment
    {
        private Segment superiorSection;
        private Way way;
        private LinkedList<Cell> length;

        /// <summary>
        /// Parametrized constructor, initializes as specified in parameters.
        /// </summary>
        /// <param name="SECTION">Parent section (Here: road)</param>
        /// <param name="WAY">The way of lane</param>
        /// <param name="LENGTH">Amount of cells in lane</param>
        public Lane(Segment SECTION, Way WAY, int LENGTH)
        { // But not sure if I should inherit length from other lanes in superiorSection.
            for( int i = 0; i < LENGTH; i++ )
            {
                length.AddLast(new Cell(this));
            }

            superiorSection = SECTION;
            way = WAY;
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
