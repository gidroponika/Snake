using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    abstract internal class Line
    {
        protected List<Symbol>line= new List<Symbol>();
        public int X { get; protected set; }
        public int Y { get; protected set; }
        
        public int Length { get; protected set; }
        public char Char { get; protected set; }
        protected Direction dir;
        public Line(int x,int y, int length, char symbol, Direction direction)
        {
            X = x;
            Y = y;
            Length = length;
            Char = symbol;
            dir= direction;

            InitialLine();
        }
        protected void InitialLine()
        {
            switch (dir)
            {
                case Direction.Right:
                    for(int i = 0; i < Length; i++)
                    {
                        line.Add(new Symbol(X + i, Y, Char));
                    }
                    break;
                case Direction.Left:
                    for(int i = 0; i < Length; i++)
                    {
                        line.Add(new Symbol(X - i, Y, Char));
                    }
                    break;
                case Direction.Down:
                    for(int i = 0; i < Length; i++)
                    {
                        line.Add(new Symbol(X, Y + i, Char));
                    }
                    break;
                case Direction.Top:
                    for(int i = 0; i < Length; i++)
                    {
                        line.Add(new Symbol(X, Y - i, Char));
                    }
                    break;
            }
        }
        virtual public void Draw()
        {
            foreach(Symbol symbol in line)
            {
                symbol.Draw();
            }
        }
    } 
}
