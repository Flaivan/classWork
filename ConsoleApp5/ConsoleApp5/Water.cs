using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Water
    {
        private double _volumeWater; //объем воды
        private double _waterSalt; //соленсоть воды

        public double GetWaterSalt() { return _waterSalt; }
        public void SetWaterSalt(double waterSalt) { _waterSalt = waterSalt; }
        public double GetVolumeWater() { return _volumeWater; }
        public void SetVolumeWater(double volumeWater) { _volumeWater = volumeWater; }
    }
}
