using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect Cube = new Rect(4, 4, 4, 4);
            Rect Square = new Rect(4, 4, 4);//Vierkant
            Rect Thiccums = new Rect(100, 100);
            Rect ThickSquare = new Rect(100);//vierkant
            
        }
    }

    public class Rect
    {
        private int x;
        private int y;
        private int width;
        private int height;


        public Rect(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            
            
        }

        public Rect(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = size;
             

             
             
             
        }

        public Rect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Rect(int size)
        {
            this.width = size;
            this.height = size;
        }

        public bool SquareCheck()
        {
            if (width == height)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void MoveTo(int x, int y)
        {

        }
    }
}
