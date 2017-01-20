using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct.data;
using test1_TrafficSim_struct.vehicles;

namespace test1_TrafficSim_struct.vehicles
{
    class Car :Vehicle
    {
        private string type; // ? TODO
        private int maxSpeed;

        /// <summary>
        /// Default constructor, sets max speed to 40.
        /// </summary>
        public Car()
        {
            type = "default";
            name = "default";
            maxSpeed = 40;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return this.name + " type:" + this.type;
        }

        public Cell GetNextCell()
        {
            return this.currentLane.GetNext(this.currentCell);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="car"></param>
        /// <param name="additionalSpeed"></param>
        /// <returns></returns>
        public static Car operator+(Car car, int additionalSpeed)
        {
            car.maxSpeed += additionalSpeed;
            return car;
        }
    }
}
