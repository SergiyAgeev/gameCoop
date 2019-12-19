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
            makeFiedl[robot.CoordinateX, robot.CoordinateY] = "[.>▀<]";
//            makeFiedl[Xx, Yy] = "[O═╦╗]";
            field.fillField(Xx,Yy,x,y);
            inputOutput.printField(makeFiedl);
            
            
            while (robot.CoordinateX != Xx && robot.CoordinateY != Yy)
            {
                field.moveRobot(robot, Xx,Yy);
                Console.ReadLine();
                
                makeFiedl[robot.CoordinateX, robot.CoordinateY] = "[*>▀<]";
                inputOutput.printField(makeFiedl);
            }
           
        }
    }
}