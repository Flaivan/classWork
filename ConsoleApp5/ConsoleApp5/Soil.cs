using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Soil
    {
        private string _soilType; //тип почвы
        private double _humidityOfSoil; //влажность почвы  

        public string GetSoilType() { return _soilType; }
        public void SetSoilType(string soilType) { _soilType = soilType; }
        public double GetHumidityOfSoil() { return _humidityOfSoil; }
        public void SetHumidityOfSoil(double humidityOfSoil) { _humidityOfSoil = humidityOfSoil; }
    }
}
