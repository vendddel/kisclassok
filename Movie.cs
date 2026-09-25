using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisclassok
{

    public record Movie(string Title, string Director, string Genre, int ReleaseYear)
    {
        private double Rating { get; set; }
        protected int ViewerCount { get; set; }


        private bool IsValidRating(double rating)
        {
            return rating >= 0 && rating <= 10;
        }


        public void UpdateRating(double newRating)
        {
            if (IsValidRating(newRating))
            {
                Rating = newRating;
            }
            else
            {
                Console.WriteLine("nem lehet valtoztatnih");
            }
        }

        protected bool IsFamous()
        {
            return ViewerCount >= 1000000;
        }

        public override string ToString()
        {
            return $"{Title} directed by {Director}, Genre: {Genre}, Released in {ReleaseYear}, Rating: {Rating}, Viewer Count: {ViewerCount}";
        }

    }
}
