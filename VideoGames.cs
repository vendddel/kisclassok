using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kisclassok
{
    public record VideoGames(string Title, string Publisher, int ReleaseYear)
    {
        private int _price {  get; set; }
        private int _releaseYear { get; init; } = ReleaseYear;
        public double _rating { get; set; }

        public int HowOld(int actYear)
        { 
            return actYear - _releaseYear;
        }

        public string CanIBuy(int money)
        {
            return _price <= money ? $"megvasarolhato, marad {money - _price} penzed" : $"meg gyujts ra tesi {_price - money} foritntottt";
        }


        public void UpdatePrice(int Newprice)
        { 
            _price = Newprice > 0 ? Newprice : _price ;
        }



    }
}
