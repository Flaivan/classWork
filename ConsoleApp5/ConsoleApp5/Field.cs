using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Field
    {
        private double _fieldSquare; //площадь поля
        private Soil _soil;
        private Plant _plant;

        public double GetFieldSquare() { return _fieldSquare; }
        public void SetFieldSquare(double fieldSquare) { _fieldSquare = fieldSquare; }
        public Soil GetSoil() { return _soil; }
        public void SetSoil(Soil soil) { _soil = soil; }
        public Plant GetPlant() { return _plant; }
        public void SetPlant(Plant plant) { _plant = plant; }
    }
}
