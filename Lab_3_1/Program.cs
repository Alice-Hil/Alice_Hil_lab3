using System;

namespace Lab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number of parking places:");
            int n = Convert.ToInt32(Console.ReadLine());

            Parking parking = new Parking(n);
            int status = 0;
            while (status == 0)
            {
                Console.WriteLine("Choose the action: 1 - park the car, 2 - take the car, 3 - check the state, 0 - exit");
                int action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        parking.ParkTheCar();
                        break;
                    case 2:
                        Console.WriteLine("Type parking place number:");
                        try
                        {
                            int number = Convert.ToInt32(Console.ReadLine());
                            parking.TakeTheCar(number);
                        }
                        catch
                        {
                            Console.WriteLine("Wrong Input!");
                        }
                        break;
                    case 3:
                        parking.ShowState();
                        break;
                    case 0:
                        status = 1;
                        break;
                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }
            }
        }
    }
}
