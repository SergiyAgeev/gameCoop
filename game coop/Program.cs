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
                    //move bot
                    case 1:
                        Console.Clear();
                        makeFiedl[x, y] = temp;
                        makeFiedl[++x, y] = "[.>▀<]";
                        inputOutput.printField(makeFiedl);
                        break;
                    //move top
                    case 2:
                        Console.Clear();
                        makeFiedl[x, y] = temp;
                        makeFiedl[--x, y] = "[.>▀<]";
                        inputOutput.printField(makeFiedl);
                        break;
                    //move right
                    case 3:
                        Console.Clear();
                        makeFiedl[x, y] = temp;
                        makeFiedl[x, ++y] = "[.>▀<]";
                        inputOutput.printField(makeFiedl);
                        break;
                    //move left
                    case 4: 
                        Console.Clear();
                        makeFiedl[x, y] = temp;
                        makeFiedl[x, --y] = "[.>▀<]";
                        inputOutput.printField(makeFiedl);
                        break;
                    default:
                        triger = false;
                        break;
                }
            
            } while ((robot.CoordinateX != Xx && robot.CoordinateY != Yy));
            
               


          
        }
    }
}