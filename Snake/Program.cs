namespace Snake
{
    enum Direction
    {
        Left,
        Right,
        Top,
        Down
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //GameScene scene = new GameScene();
            Console.SetWindowSize(100, 45);
            Console.SetBufferSize(100, 45);
            Console.CursorVisible = false;

            Border left = new Border(0, 0, 36, '#', Direction.Down);
            Border right = new Border(99, 0, 35, '#', Direction.Down);
            Border top = new Border(0, 0, 100, '#', Direction.Right);
            Border down = new Border(0, 35, 100, '#', Direction.Right);
            Food food = new Food('*');
            
            
            left.Draw();
            right.Draw();
            top.Draw();
            down.Draw();
            Console.WriteLine("\n\nSCORE 0");
            while (true)
            {
                Thread.Sleep(1000);
                food.Draw();
            }
        }
    }
}