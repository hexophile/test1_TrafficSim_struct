using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1_TrafficSim_struct.data
{
    public class ObjectInfo
    {
        protected string name;
        protected Coordinates coords;

        public virtual string GetName()
        {
            return this.name;
        }
    }
}
