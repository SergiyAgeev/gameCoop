using System;

namespace game_coop
{
    public static class inputOutput
    {
        
      public static String brickModel = "[    ]";
      public static String robotModel = "[.>▀<]";

        public static string readString()
        {
            string temp = Console.ReadLine();
            return temp;
        }

        public static void printField(string[,] field)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0, 6}", field[i, j]);
                }
            }
        }

        public static int readXcoordinate()
        {
            Console.WriteLine("Input X coordinate");
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }

        public static int readYcoordinate()
        {
            Console.WriteLine("Input Y coordinate");
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }

        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 9);
        }
    }
}