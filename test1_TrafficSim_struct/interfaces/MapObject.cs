using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.data;

namespace test1_TrafficSim_struct.interfaces
{
    /// <summary>
    /// Map object is primary interface for all objects used in simulation.
    /// </summary>
    public interface MapObject
    {
        /// <summary>
        /// Standard co-ordinates' getter
        /// </summary>
        /// <returns>Object's co-ordinates</returns>
        Coordinates GetCoordinates();
    }
}
