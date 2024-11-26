using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolao.Models.Entities
{
    public sealed class Game
    {
        public int Min { get; set; }

        public int Max { get; set; }

        public int Range { get; set; }
        public HashSet<int> Numbers { get; set; }


        public Game() { }  
        public Game(int min, int max, int range, HashSet<int> numbers)
        {
            Min = min;
            Max = max;
            Range = range;
            Numbers = numbers;
        }
    }
}
