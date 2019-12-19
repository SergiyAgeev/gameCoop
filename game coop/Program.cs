using System;

namespace game_coop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool triger = true;
            String temp = "[    ]";
            int Xx = inputOutput.RandomNumber();
            int Yy = inputOutput.RandomNumber();
            int x = inputOutput.readXcoordinate();
            int y = inputOutput.readYcoordinate();
            GameField field = new GameField();
            Robot robot = new Robot(Direction.UP, x, y);

            string[,] makeFiedl = field.Field;
            field.fillField(Xx, Yy, x, y);
            makeFiedl[robot.CoordinateX, robot.CoordinateY] = "[.>▀<]";
            inputOutput.printField(makeFiedl);
            
            do
            {
                int cursour =Convert.ToInt32(Console.ReadLine());
                switch (cursour)
                {
                    //move right
                    case 1:
                        Console.Clear();
                        makeFiedl[x, y] = temp;
                        makeFiedl[++x, y] = "[.>▀<]";
                        inputOutput.printField(makeFiedl);
                        break;
                    case 2:
                        robot.moveTop();
                        break;
                    case 3:
                        robot.moveBottom();
                        break;
                    case 4:
                        robot.moveLeft();
                        break;
                    default:
                        triger = false;
                        break;
                }
            
            } while ((robot.CoordinateX != Xx && robot.CoordinateY != Yy));
            
               


          
        }
    }
}