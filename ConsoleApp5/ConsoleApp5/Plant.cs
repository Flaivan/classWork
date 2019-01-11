using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Plant
    {
        private string _plantsType; //тип ростения
        private double _rightAmountOfWater; //нужная кол воды

        public string GetPlantsType() { return _plantsType; }
        public void SetPlantsType(string plantsType) { _plantsType = plantsType; }
        public double GetRightAmountOfWater() { return _rightAmountOfWater; }
        public void SetRightAmountOfWater(double rightAmountOfWater) { _rightAmountOfWater = rightAmountOfWater; }
    }
}
