using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class RainMachine
    {
        private string _irrigationType; //тип орошения
        private string _rainMachineType; //тип дожедвой машины
        private double _rainMachineOperativeSquare; //рабочая площадь машины
        private double _consumedEnergy; //потребляемая энергия
        private Water _water;

        public double GetConsumedEnergy() { return _consumedEnergy; }
        public void SetConsumedEnergy() { _consumedEnergy = _consumedEnergy; }
        public string GetIrrigationType() { return _irrigationType; }
        public void SetIrrigationType(string irrigationType) { _irrigationType = irrigationType; }
        public string GetRainMachineType() { return _rainMachineType; }
        public void SetRainMachineType(string rainMachineType) { _rainMachineType = rainMachineType; }
        public double GetRainMachineOperativeSquare() { return _rainMachineOperativeSquare; }
        public void SetRainMachineOperativeSquare(double rainMachineOperativeSquare) { _rainMachineOperativeSquare = rainMachineOperativeSquare; }
        public Water GetWater() { return _water; }
        public void SetWater(Water water) { _water = water; }
    }
}
