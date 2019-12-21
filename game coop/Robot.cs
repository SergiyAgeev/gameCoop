using System;
using System.Threading;

namespace game_coop
{
    public class Robot
    {
        public delegate void PushButton();


        private int coordinateX;
        private int coordinateY;

        public Robot(int coordinateX, int coordinateY)
        {

            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }


        public event PushButton pushbutton;

        public void DoEvent()
        {
            if (pushbutton != null)
                pushbutton();
        }



        public int CoordinateX
        {
            get => coordinateX;
            set => coordinateX = value;
        }

        public int CoordinateY
        {
            get => coordinateY;
            set => coordinateY = value;
        }

        public void moveRight()
        {
            
        }

        public void moveTop()
        {
        }

        public void moveLeft()
        {
        }

        public void moveBottom()
        {
        }

       
    }
}