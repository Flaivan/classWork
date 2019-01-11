using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Energy
    {
        private string _producesMachine; //какая машина которая выробатывает энергию
        private double _producedPower; //кол энергий которая выробатывает машина

        public string GetProducesMachine() { return _producesMachine; }
        public void SetProducesMachine(string producesMachine) { _producesMachine = producesMachine; }
        public double GetProducedPower() { return _producedPower; }
        public void SetProducedPower(double producedPower) { _producedPower = producedPower; }
    }
}
