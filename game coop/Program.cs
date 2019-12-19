using System;

namespace game_coop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int Xx = inputOutput.RandomNumber();
            int Yy = inputOutput.RandomNumber();
            int x = inputOutput.readXcoordinate();
            int y = inputOutput.readYcoordinate();
            GameField field = new GameField();
            Robot robot = new Robot(Direction.UP, x, y);


            string[,] makeFiedl = field.Field;
            field.fillField(Xx, Yy, x, y);
            makeFiedl[robot.CoordinateX, robot.CoordinateY] = inputOutput.robotModel;
            inputOutput.printField(makeFiedl);


            do
            {
                String cursour = (Console.ReadLine());
                switch (cursour)
                {
                    //move bot
                    case "s":
                        robot.pushbutton += (robot.moveRight);
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[++x, y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                        } while (Console.ReadKey(true).KeyChar == 's');

                        break;
                    //move top
                    case "w":
                        robot.pushbutton += (robot.moveTop);
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[--x, y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                        } while (Console.ReadKey(true).KeyChar == 'w');

                        break;
                    //move right
                    case "d":
                        robot.pushbutton += (robot.moveRight);
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[x, ++y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                        } while (Console.ReadKey(true).KeyChar == 'd');

                        break;
                    //move left
                    case "a":
                        robot.pushbutton += (robot.moveLeft);
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[x, --y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                        } while (Console.ReadKey(true).KeyChar == 'a');
                        break;
                    default:
                        break;
                }
            } while ((robot.CoordinateX != Xx && robot.CoordinateY != Yy));
        }
    }
}