using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP_Exam
{
    public class Weather
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public Weather(string name,double temp)
        {
            Name = name;
            Temperature = temp;
        }
        public override string ToString()
        {
            return $"Погода: {Name}\nТемпература: {Temperature}";
        }
    }
}
