using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisclassok
{
    public record Book(string Title, string Author, int Pages)
    {
        public double Price {  get; set; }

        public void UpdatePrice(double percent)
        {
            Price *= (100 - percent) / 100;
        }


        public double GetPrice3()
        {
            return Price * 3;
        }
    }
}
