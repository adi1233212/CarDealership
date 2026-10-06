using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ElectricCars:Cars
    {

        private int batteryCapacity;
        private int range;
        private string chargingTime;

        public int BatteryCapacity { get => batteryCapacity; set => batteryCapacity = value; }
        public int Range { get => range; set => range = value; }
        public string ChargingTime { get => chargingTime; set => chargingTime = value; }
    }
}
