using System;
using System.Drawing;
using System.Threading;


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
         public static bool boolCheck(int x, int y, int Y, int X)
        {
            int i = 0;
            if (x == X && y == Y)
            {
                Console.Clear();
                while (i != 1)
                {
                    while (i != 5)
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
                    Console.Beep(247, 500);
                    Console.Beep(417, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(417, 500);
                    Console.Beep(329, 500);
                    Console.Beep(247, 500);
                    Console.Beep(247, 500);
                    Console.Beep(247, 500);
                    Console.Beep(417, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(417, 500);
                    Console.Beep(497, 500);
                    Thread.Sleep(500);
                    Console.Beep(497, 500);
                    Console.Beep(277, 500);
                    Console.Beep(277, 500);
                    Console.Beep(440, 500);
                    Console.Beep(440, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(329, 500);
                    Console.Beep(247, 500);
                    Console.Beep(417, 500);
                    Console.Beep(417, 500);
                    Console.Beep(370, 500);
                    Console.Beep(417, 500);
                    Console.Beep(329, 500);
                    i++;
                }
                return false;
            }
            return true;
        }
         public static void GameOver()
         {
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("GAME OVER!\nYOUR ROBOT CRASHED!\nPRESS ANY KEY FOR EXIT");
             Console.ReadLine();
         }
    }
}