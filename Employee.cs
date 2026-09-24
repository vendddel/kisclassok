using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisclassok
{
    internal record Employee(string Name, string Position)
    {
        private int _salary {  get; set; }
        private int _workedHours { get; set; }
        private int _overtime { get; set;}


        private double Oraber()
        {
            return _workedHours / 160.0;
        }

        public double OverTimeWage()
        {
            return Oraber() * 1.5 * _overtime;
        }

        public void UpdateWage(int hours)
        {
            if (_workedHours + hours >= 160)
            {
                _overtime += (_workedHours + hours-160);
                _workedHours = 160;
            }
            else
            {
                _workedHours += hours;
            }
        }
    }
}
