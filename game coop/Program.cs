using System;

namespace game_coop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int Xx = inputOutput.RandomNumber();
            int Yy = inputOutput.RandomNumber();
            int x = inputOutput.readXcoordinate();
            int y = inputOutput.readYcoordinate();
            GameField field = new GameField();
            Robot robot = new Robot(x, y);


            string[,] makeFiedl = field.Field;
            field.fillField(Xx, Yy, x, y);
            if (Xx == x && Yy == y)
            {
                Xx = inputOutput.RandomNumber();
                Yy = inputOutput.RandomNumber();
            }

            makeFiedl[robot.CoordinateX, robot.CoordinateY] = inputOutput.robotModel;
            inputOutput.printField(makeFiedl);
            bool triger = true;

            do
            {
                ConsoleKeyInfo k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.DownArrow) //move bot
                {
                    try
                    {
                        robot.pushbutton += (robot.moveBottom);

                        Console.Clear();
                        makeFiedl[x, y] = inputOutput.brickModel;
                        makeFiedl[++x, y] = inputOutput.robotModel;
                        robot.DoEvent();
                        Console.Beep(340, 100);
                        inputOutput.printField(makeFiedl);
                        triger = inputOutput.boolCheck(x, y, Yy, Xx);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        inputOutput.GameOver();
                        triger = false;
                    }

                    inputOutput.boolCheck(x, y, Yy, Xx);
                }
                else if (k.Key == ConsoleKey.UpArrow) //move top
                {
                    try
                    {
                        robot.pushbutton += (robot.moveTop);

                        Console.Clear();
                        makeFiedl[x, y] = inputOutput.brickModel;
                        makeFiedl[--x, y] = inputOutput.robotModel;
                        robot.DoEvent();
                        Console.Beep(340, 100);
                        inputOutput.printField(makeFiedl);
                        triger = inputOutput.boolCheck(x, y, Yy, Xx);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        inputOutput.GameOver();
                        triger = false;
                    }

                    inputOutput.boolCheck(x, y, Yy, Xx);
                }
                else if (k.Key == ConsoleKey.RightArrow) //move right
                {
                    try
                    {
                        robot.pushbutton += (robot.moveRight);

                        Console.Clear();
                        makeFiedl[x, y] = inputOutput.brickModel;
                        makeFiedl[x, ++y] = inputOutput.robotModel;
                        robot.DoEvent();
                        Console.Beep(340, 100);
                        inputOutput.printField(makeFiedl);
                        triger = inputOutput.boolCheck(x, y, Yy, Xx);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        inputOutput.GameOver();
                        triger = false;
                    }

                    inputOutput.boolCheck(x, y, Yy, Xx);
                }
                else if (k.Key == ConsoleKey.LeftArrow) //move left
                {
                    try
                    {
                        robot.pushbutton += (robot.moveLeft);
                        Console.Clear();
                        makeFiedl[x, y] = inputOutput.brickModel;
                        makeFiedl[x, --y] = inputOutput.robotModel;
                        robot.DoEvent();
                        Console.Beep(340, 100);
                        inputOutput.printField(makeFiedl);
                        triger = inputOutput.boolCheck(x, y, Yy, Xx);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        inputOutput.GameOver();
                        triger = false;
                    }

                    inputOutput.boolCheck(x, y, Yy, Xx);
                }
            } while (triger != false);
        }
    }
}