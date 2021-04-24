using System;

namespace _3._ข้อมูลกล้อง
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Mode : ");
            string mode = Console.ReadLine();
            bool check = false;
            while(check == false)
            {
                Console.Write("Input FilmBackWidth : ");
                float filmBackWidth = float.Parse(Console.ReadLine());
                if (filmBackWidth > 0)
                {
                    double fLength = 0;
                    double fov = 0;
                    if (mode == "fLength")
                    {
                        while (check == false)
                        {
                            Console.Write("Input fLength : ");
                            fLength = double.Parse(Console.ReadLine());
                            if (fLength > 0)
                            {
                                fov = 2 * Math.Atan(filmBackWidth / (2 * fLength));
                                Console.WriteLine("fLength = {0} \nfov = {1}", fLength, fov);
                                check = true;
                            }
                            else
                                Console.WriteLine("Invalid fLength. Please input again.");
                        }
                    }
                    else if (mode == "fov")
                    {
                        while (check == false)
                        {
                            Console.Write("Input fov : ");
                            fov = double.Parse(Console.ReadLine());
                            if (fov > 0.1 && fov < 6.28)
                            {
                                fLength = filmBackWidth / (2 * Math.Tan(fov / 2));
                                Console.WriteLine("fLength = {0} \nfov = {1}", fLength, fov);
                                check = true;
                            }
                            else
                                Console.WriteLine("Invalid fov. Please input again.");
                        }
                    }
                    else
                        Console.WriteLine("ERROR Please Input Mode try again.");
                    check = true;
                }
                else
                    Console.WriteLine("Invalid filmBackWidth. Please input again.");
            }
        }
    }
}
