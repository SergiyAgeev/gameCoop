using System;
using System.Threading;

namespace game_coop
{
    public class Robot
    {
        public delegate void PushButton();

        
        private int coordinateX;
        private int coordinateY;

        public Robot( int coordinateX, int coordinateY)
        {
            
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }


        public event PushButton pushbutton;

        public void DoEvent()
        {
            if (pushbutton != null)
                pushbutton();
        }

      

        public int CoordinateX
        {
            get => coordinateX;
            set => coordinateX = value;
        }

        public int CoordinateY
        {
            get => coordinateY;
            set => coordinateY = value;
        }

        public void moveRight()
        {
        }

        public void moveTop()
        {
        }

        public void moveLeft()
        {
        }

        public void moveBottom()
        {
        }

        public bool boolCheck(int x, int y, int Y, int X)
        {
            int i = 0;
            if (x == X && y == Y)
            {
                Console.Clear();
                while (i != 50)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.WriteLine("OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("    OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Thread.Sleep(150);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.WriteLine("    OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("    OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Thread.Sleep(150);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.WriteLine("OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("    OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Thread.Sleep(150);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.WriteLine("    OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("    OMG YOU WIN 1 000 000 000 $");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Thread.Sleep(150);
                    i++;
                }
                return false;
            }
            return true;
        }
    }
}

