using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Symbol
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public char Char { get; protected set; }

        public Symbol() { }
        public Symbol(int x,int y,char symbol)
        {
            X = x;
            Y = y;
            Char = symbol;
        }

        virtual public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Char);
        }
        virtual public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(Char);
        }
    }
}
