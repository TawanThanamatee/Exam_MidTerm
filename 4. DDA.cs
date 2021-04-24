using System;

namespace _4._DDA
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            Console.Write("Input x1 : ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Input y1 : ");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Input x2 : ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Input y2 : ");
            float y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
                step = Math.Abs(dy);
            dx = dx / step; dy = dy / step; x = x1; y = y1;int i = 1;
            bool check = false;
            while (check == false)
            {
                if (i <= step)
                {
                    Console.WriteLine("x = {0} , y = {1}", x, y);
                    x = x + dx; y = y + dy; i++;
                }
                else
                    check = true;
            }
        }
    }
}
