using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SetMap
    {
        public static Dictionary<int, int> landings = new Dictionary<int, int>();
        public SetMap()
        {
            landings.Add(3, 16);
            landings.Add(10, 32);
            landings.Add(18, 7);
            landings.Add(21, 37);
            landings.Add(28, 82);
            landings.Add(39, 60);
            landings.Add(51, 67);
            landings.Add(59, 49);
            landings.Add(63, 81);
            landings.Add(69, 91);
            landings.Add(86, 23);
            landings.Add(94, 72);
            landings.Add(96, 74);
            landings.Add(99, 77);
        }
    }
}
