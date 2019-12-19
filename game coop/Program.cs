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
            Robot robot = new Robot( x, y);


            string[,] makeFiedl = field.Field;
            field.fillField(Xx, Yy, x, y);
            if (Xx == x && Yy ==y)
            {
                Environment.Exit(0);
            }
            makeFiedl[robot.CoordinateX, robot.CoordinateY] = inputOutput.robotModel;
            inputOutput.printField(makeFiedl);
            bool triger = true;
         
            do
            {
                String cursour = (Console.ReadLine());
                switch (cursour)
                {
                    //move bot
                    case "s":
                        try
                        {
                            robot.pushbutton += (robot.moveBottom);
                            do
                            {
                                Console.Clear();
                                makeFiedl[x, y] = inputOutput.brickModel;
                                makeFiedl[++x, y] = inputOutput.robotModel;
                                robot.DoEvent();
                                inputOutput.printField(makeFiedl);
                                triger = robot.boolCheck(x, y, Yy, Xx);
                            } while (Console.ReadKey(true).KeyChar == 's');
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("GAME OVER!\nYOUR ROBOT CRASHED!\nPRESS ANY KEY FOR EXIT");
                            Console.ReadLine();
                            triger = false;
                        }

                        robot.boolCheck(x, y, Yy, Xx);
                        break;
                    //move top
                    case "w":
                        try
                        {
                            robot.pushbutton += (robot.moveTop);
                            do
                            {
                                Console.Clear();
                                makeFiedl[x, y] = inputOutput.brickModel;
                                makeFiedl[--x, y] = inputOutput.robotModel;
                                robot.DoEvent();
                                inputOutput.printField(makeFiedl);
                                triger = robot.boolCheck(x, y, Yy, Xx);
                            } while (Console.ReadKey(true).KeyChar == 'w');
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("GAME OVER!\nYOUR ROBOT CRASHED!\nPRESS ANY KEY FOR EXIT");
                            Console.ReadLine();
                            triger = false;
                        }

                        robot.boolCheck(x, y, Yy, Xx);
                        break;
                    //move right
                    case "d":
                        try
                        {
                            robot.pushbutton += (robot.moveRight);
                            do
                            {
                                Console.Clear();
                                makeFiedl[x, y] = inputOutput.brickModel;
                                makeFiedl[x, ++y] = inputOutput.robotModel;
                                robot.DoEvent();
                                inputOutput.printField(makeFiedl);
                                triger = robot.boolCheck(x, y, Yy, Xx);
                            } while (Console.ReadKey(true).KeyChar == 'd');
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("GAME OVER!\nYOUR ROBOT CRASHED!\nPRESS ANY KEY FOR EXIT");
                            Console.ReadLine();
                            triger = false;
                        }

                        robot.boolCheck(x, y, Yy, Xx);
                        break;
                    //move left
                    case "a":
                        try
                        {
                            robot.pushbutton += (robot.moveLeft);
                            do
                            {
                                Console.Clear();
                                makeFiedl[x, y] = inputOutput.brickModel;
                                makeFiedl[x, --y] = inputOutput.robotModel;
                                robot.DoEvent();
                                inputOutput.printField(makeFiedl);
                                triger = robot.boolCheck(x, y, Yy, Xx);
                            } while (Console.ReadKey(true).KeyChar == 'a');
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("GAME OVER!\nYOUR ROBOT CRASHED!\nPRESS ANY KEY FOR EXIT");
                            Console.ReadLine();
                            triger = false;
                        }

                        robot.boolCheck(x, y, Yy, Xx);

                        break;
                    default:
                        break;
                }
            } while (triger != false);
        }
    }
}