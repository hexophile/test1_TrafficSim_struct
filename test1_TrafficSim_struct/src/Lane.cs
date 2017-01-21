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
        private static long count = 0;
        private Segment superiorSection;
        private Direction way;
        private LinkedList<Cell> cells;

        /// <summary>
        /// Parametrized constructor, initializes as specified in parameters.
        /// </summary>
        /// <param name="SECTION">Parent section (Here: road)</param>
        /// <param name="WAY">The way of lane</param>
        /// <param name="LENGTH">Amount of cells in lane</param>
        public Lane(Segment SECTION, Direction WAY, int LENGTH)
        { // But not sure if I should inherit length from other lanes in superiorSection.
            cells = new LinkedList<Cell>();
            for( int i = 0; i < LENGTH; i++ )
            {
                cells.AddLast(new Cell(this));
            }

            count++;
            name = "User_defined_Lane" + count;
            superiorSection = SECTION;
            way = WAY;
        }

        /// <summary>
        /// Returns next cell of the specified cell.
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        public Cell GetNext(Cell cell)
        {
            return cells.Find(cell).Next.Value;
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
