using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.interfaces;

namespace test1_TrafficSim_struct
{
    /// <summary>
    /// World object interface contains set of basic function headers that are needed to operate objects.
    /// </summary>
    public interface WorldObject :MapObject // well, each world object is supposed to have coords (vehicles, obstacles etc.)
    {
        // TODO
    }
}
