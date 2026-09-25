using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisclassok
{

    // A record az alábbi adatokat tárolja:
    // - Name : string – public, immutable
    // - Nationality : string – public, immutable
    // - BirthYear : int – private, immutable
    // - Team : string – private, mutable
    // - Goals : int – protected, mutable
    // - Matches : int – protected, mutable
    public record FootballPlayer(string Name, string Nationality, int BirthYear)
    {
        private string Team { get; set; }
        protected int Goals { get; set; }
        protected int Matches { get; set; }




        public void UpdateStats(int goalsScored)
        {
            Matches++;
            Goals += goalsScored;
        }

        public double GoalAverage()
        {
            if (Matches == 0)
            {
                return 0;
            }
            return (double)Goals / Matches;
        }

        private bool IsTransferable()
        {
            return Matches >= 10;

        }

        public void TransferTo(string newTeam)
        {
            if (IsTransferable())
            {
                Team = newTeam;
            }
            else
            {
                Console.WriteLine($"{Name} is not transferable yet.");
            }
        }
    }
}
