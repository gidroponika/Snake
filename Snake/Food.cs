using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food : Symbol
    {
        Random random = new Random();
        public Food(char symbol)
        {
            Char = symbol;
        }
        public Food(int x, int y, char symbol)
            : base(x, y, symbol)
        {

        }
        public override void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(' ');
            SetRandomCoordinat();
            base.Draw();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        void SetRandomCoordinat()
        {
            X= random.Next(1, 100);
            Y= random.Next(1, 35);
        }
    }
}
