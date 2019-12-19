using System;

namespace game_coop
{
    public class GameField
    {
        string[,] field = new string[10, 10];

        public string[,] Field
        {
            get => field;
            set => field = value;
        }


        public void fillField(int a,int b,int aa, int bb)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    field[i, j] = "[    ]";
                    
                }
            }
           
            field[a, b] = "[O═╦╗]";
        }

        public delegate void PushButton();

        public event PushButton pushbutton;

        public void DoEvent()
        {
            if (pushbutton != null)
                pushbutton();
        }

        public void moveRobot()
        {
            Console.WriteLine("robot moved ");
        }

//        public void moveRobot(Robot robot, int toX, int toY)
//        {
//            
////            if (toX < robot.CoordinateX)
////            {
////                while (Direction.LEFT != robot.Direction)
////                {
////                    robot.turnLeft();
////                }
////            }
////            else
////            {
////                while (Direction.RIGHT != robot.Direction)
////                {
////                    robot.turnRight();
////                    
////                }
////            }
////
////            while (toX != robot.CoordinateX)
////            {
////                robot.stepForward();
////                
////            }
////
////            if (toY < robot.CoordinateY)
////            {
////                while (Direction.DOWN != robot.Direction)
////                {
////                    robot.turnRight();
////                    
////                }
////            }
////            else
////            {
////                while (Direction.UP != robot.Direction)
////                {
////                    robot.turnLeft();
////                    
////                }
////            }
////
////            while (toY != robot.CoordinateY)
////            {
////                robot.stepForward();
////                
////            }
//        }
    }
}