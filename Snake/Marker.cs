using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Marker
    {
        public int pos;
        public string name;

        public Marker(string playerName)
        {
            this.pos = 1;
            this.name = playerName;
        }
    }
}
