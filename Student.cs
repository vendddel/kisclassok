using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisclassok
{
    internal record Student(string name, string className, int BirthYear)
    {
        private double _average {  get; set; }
        public void UpdateAverage(double newAverage)
        {
            _average = newAverage >= 1.0 && newAverage <= 5.0 ? newAverage : _average;
        }


        public string Grading()
        {
            switch (_average)
                
            {
                case < 2.0:
                    return "Fejlseztendő";


                case < 3.5:
                    return "Megfelelt";

                case < 4.5:
                    return "Jó";

                default:
                   return "Kiváló";
            }
        }

    }
}
