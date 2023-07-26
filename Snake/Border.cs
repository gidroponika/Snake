using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Border : Line
    {
        public Border(int x, int y, int length, char symbol, Direction direction) :
            base(x, y, length, symbol, direction)
        {
        }
    }
}
