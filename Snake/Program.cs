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
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Border top = new Border(0, 0, 100, '#', Direction.Right);
            Border down = new Border(0, 35, 100, '#', Direction.Right);
            top.Draw();
            down.Draw();
        }
    }
}