using System;
using System.Threading;

namespace game_coop
{
    public class Robot
    {
        public delegate void PushButton();
        private Direction direction;
        private int coordinateX;
        private int coordinateY;

        public Robot(Direction direction, int coordinateX, int coordinateY)
        {
            this.direction = direction;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }
        
        

        public event PushButton pushbutton;
        public void DoEvent()
        {
            if (pushbutton != null)
                pushbutton();
        }

        public Direction Direction
        {
            get => direction;
            set => direction = value;
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
        
        

        
        
        public void turnLeft() {
            switch (direction) {
                case Direction.UP:
                    direction = Direction.LEFT;
                    break;
                case Direction.LEFT:
                    direction = Direction.DOWN;
                    break;
                case Direction.DOWN:
                    direction = Direction.RIGHT;
                    break;
                case Direction.RIGHT:
                    direction = Direction.UP;
                    break;
                default:
                    break;
            }
        }

        public void turnRight() {
            switch (direction) {
                case Direction.UP:
                    direction = Direction.RIGHT;
                    break;
                case Direction.LEFT:
                    direction = Direction.UP;
                    break;
                case Direction.DOWN:
                    direction = Direction.LEFT;
                    break;
                case Direction.RIGHT:
                    direction = Direction.DOWN;
                    break;
                default:
                    break;
            }
        }

        public void stepForward() {
            switch (direction) {
                case Direction.UP:
                    coordinateY++;
                    break;
                case Direction.LEFT:
                    coordinateX--;
                    break;
                case Direction.DOWN:
                    coordinateY--;
                    break;
                case Direction.RIGHT:
                    coordinateX++;
                    break;
                default:
                    break;
            }
        }
    }
}