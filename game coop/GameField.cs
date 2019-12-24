using System;
using System.Drawing;
using System.Runtime.Serialization;


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

        public void fillField(int a, int b, int aa, int bb)
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
    }
}