using System;

namespace _5._GraspFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day of Week : ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Time of Day : ");
            int Time = int.Parse(Console.ReadLine());
            int Breakfast_Set = 5, Weekend_Set = 2, Coffee = 3;
            
            bool check = false;
            switch(Day)
            {
                case 1:case 2:case 3:case 4:case 5:

                    switch(Time)
                    {
                        case 8:case 9:case 10:case 11:
                            while(check == false)
                            {
                                
                                Console.Write("Order : ");
                                string Menu = Console.ReadLine();
                                
                                if (Menu == "Breakfast Set")
                                {
                                    if (Breakfast_Set > 0)
                                    {
                                        Breakfast_Set = Breakfast_Set - 1;
                                        Console.WriteLine("Breakfast Set = " + Breakfast_Set);
                                    }
                                   else if(Breakfast_Set == 0)
                                    {
                                        Console.WriteLine("Sorry your order is out of stock");
                                    }                                 
                                }
                                else if(Menu == "Coffee")
                                {
                                    if (Coffee > 0)
                                    {
                                        Coffee = Coffee - 1;
                                        Console.WriteLine("Coffee = " + Coffee);
                                    }
                                   else if (Coffee == 0)
                                    {
                                        Console.WriteLine("Sorry your order is out of stock");
                                    }
                                }
                                else if(Menu == "Weekend Set")
                                {
                                    Console.WriteLine("Sorry your order is not available");
                                }
                                else if(Menu == "End")
                                {
                                    check = true;
                                }
                            }
                            break;
                        case 12:case 13:case 14:case 15:case 16:case 17:case 18:
                            while (check == false)
                            {

                                Console.Write("Order : ");
                                string Menu = Console.ReadLine();
                                if (Menu == "Coffee")
                                {
                                    if (Coffee > 0)
                                    {
                                        Coffee = Coffee - 1;
                                        Console.WriteLine("Coffee = " + Coffee);
                                    }
                                    else if (Coffee == 0)
                                    {
                                        Console.WriteLine("Sorry your order is out of stock");
                                    }
                                }
                                else if (Menu == "Weekend Set")
                                {
                                    Console.WriteLine("Sorry your order is not available");
                                }
                                else if (Menu == "Breakfast Set")
                                {
                                    Console.WriteLine("Sorry your order is not available");
                                }
                                else if (Menu == "End")
                                {
                                    check = true;
                                }
                            }
                                break;
                    }
                    break;
                case 6:case 7:
                    switch (Time)
                    {
                        case 8:case 9:case 10:case 11:
                            while (check == false)
                            {

                                Console.Write("Order : ");
                                string Menu = Console.ReadLine();

                                if (Menu == "Breakfast Set")
                                {
                                    if (Breakfast_Set > 0)
                                    {
                                        Breakfast_Set = Breakfast_Set - 1;
                                        Console.WriteLine("Breakfast Set = " + Breakfast_Set);
                                    }
                                    else if (Breakfast_Set == 0)
                                    {
                                        Console.WriteLine("Sorry your order is out of stock");
                                    }
                                }
                                else if (Menu == "Coffee")
                                {
                                    if (Coffee > 0)
                                    {
                                        Coffee = Coffee - 1;
                                        Console.WriteLine("Coffee = " + Coffee);
                                    }
                                    else if (Coffee == 0)
                                    {
                                        Console.WriteLine("Sorry your order is out of stock");
                                    }
                                }
                                else if (Menu == "Weekend Set")
                                {
                                    if (Weekend_Set > 0)
                                    {
                                        Weekend_Set = Weekend_Set - 1;
                                        Console.WriteLine("Weekend Set = " + Weekend_Set);
                                    }
                                    else if (Weekend_Set == 0)
                                    {
                                        Console.WriteLine("Sorry your order is out of stock");
                                    }
                                }
                                else if (Menu == "End")
                                {
                                    check = true;
                                }
                            }
                            break;
                        case 12:case 13:case 14:case 15:case 16:case 17:case 18:
                            {
                                while (check == false)
                                {

                                    Console.Write("Order : ");
                                    string Menu = Console.ReadLine();

                                    if (Menu == "Breakfast Set")
                                    {
                                        Console.WriteLine("Sorry your order is not available");
                                    }
                                    else if (Menu == "Coffee")
                                    {
                                        if (Coffee > 0)
                                        {
                                            Coffee = Coffee - 1;
                                            Console.WriteLine("Coffee = " + Coffee);
                                        }
                                        else if (Coffee == 0)
                                        {
                                            Console.WriteLine("Sorry your order is out of stock");
                                        }
                                    }
                                    else if (Menu == "Weekend Set")
                                    {
                                        if (Weekend_Set > 0)
                                        {
                                            Weekend_Set = Weekend_Set - 1;
                                            Console.WriteLine("Weekend Set = " + Weekend_Set);
                                        }
                                        else if (Weekend_Set == 0)
                                        {
                                            Console.WriteLine("Sorry your order is out of stock");
                                        }
                                    }
                                    else if (Menu == "End")
                                    {
                                        check = true;
                                    }
                                }
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
