using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class GameScene
    {
        public GameScene() {
            Initialize();
        }
        void Initialize()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);
            
        }
    }
}
