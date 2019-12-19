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
            bool triger = true;

            do
            {
                String cursour = (Console.ReadLine());
                switch (cursour)
                {
                       
                    //move bot
                    case "s":
                        robot.pushbutton += (robot.moveBottom);
                        
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[++x, y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                            triger =  robot.boolCheck(x, y, Yy, Xx);
                        } while (Console.ReadKey(true).KeyChar == 's');

                        break;
                    //move top
                    case "w":
                        robot.pushbutton += (robot.moveTop);
                        
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[--x, y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                            triger =  robot.boolCheck(x, y, Yy, Xx);
                        } while (Console.ReadKey(true).KeyChar == 'w');

                       
                        break;
                    //move right
                    case "d":
                        robot.pushbutton += (robot.moveRight);
                        
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[x, ++y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                            triger =  robot.boolCheck(x, y, Yy, Xx);
                        } while (Console.ReadKey(true).KeyChar == 'd');

                        robot.boolCheck(x, y, Yy, Xx);
                        break;
                    //move left
                    case "a":
                        robot.pushbutton += (robot.moveLeft);
                        
                        do
                        {
                            Console.Clear();
                            makeFiedl[x, y] = inputOutput.brickModel;
                            makeFiedl[x, --y] = inputOutput.robotModel;
                            robot.DoEvent();
                            inputOutput.printField(makeFiedl);
                            triger =  robot.boolCheck(x, y, Yy, Xx);
                        } while (Console.ReadKey(true).KeyChar == 'a');
                       
                        break;
                    default:
                        break;
                    
                }
            } while (triger != false);

            
        }
    }
}