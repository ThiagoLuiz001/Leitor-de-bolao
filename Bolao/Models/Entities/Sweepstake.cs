using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolao.Models.Entities
{
    public class Sweepstake : IComparable
    {
        public string Player { get; set; }
        public HashSet<int> Game { get; set; }
        public int Hits { get; set; }

        public Sweepstake(string player, HashSet<int> game)
        {
            Player = player;
            Game = game;
        }

        public int CompareTo(object? obj)
        {
           if (!(obj is Sweepstake))
            {
                throw new Exception("O objeto Comparado não é um Sweepstake!");
            }
           var other = obj as Sweepstake;
           return Hits.CompareTo(other.Hits);
        }
    }
}
