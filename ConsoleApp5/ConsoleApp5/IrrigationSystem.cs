using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class IrrigationSystem
    {
        private Field _field;
        private RainMachine _rainMachine;
        private Energy _energy;

        public Energy GetEnergy() { return _energy; }
        public void SetEnergy(Energy energy) { _energy = energy; }
        public Field GetField() { return _field; }
        public void SetField(Field field) { _field = field; }
        public RainMachine GetRainMachine() { return _rainMachine; }
        public void SetRainMachine(RainMachine rainMachine) { _rainMachine = rainMachine; }
    }
}
