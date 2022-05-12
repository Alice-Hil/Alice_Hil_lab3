using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_1
{
    class Parking
    {
        public List<ParkingSpace> parking;
        private int maxCount;
        public Parking(int n)
        {
            parking = new List<ParkingSpace>();
            maxCount = n;
            int i = 0;
            while (i < maxCount)
            {
                parking.Add(new ParkingSpace());
                i++;
            }
        }

        private int FindFreeSpace()
        {
            for (int i = 0; i < maxCount; i++)
            {
                if (parking[i].isFree)
                {
                    return i;
                }
            }
            return maxCount;
        }
        
        public void ParkTheCar()
        {
            int index = FindFreeSpace();
            if (index == maxCount)
            {
                Console.WriteLine("There is no free parking places. Wait and try later");
            }
            else
            {
                parking[index].isFree = false;
                Console.WriteLine("The car was parked on " + (index+1) + " place");
            }
        }

        public void TakeTheCar(int parkingSpace)
        {
            int index = parkingSpace-1;
            if (!parking[index].isFree)
            {
                parking[index].isFree = true;
                Console.WriteLine("The parking space #" + parkingSpace + " became free");
            }
            else
            {
                Console.WriteLine("There is no car on parking place #" + parkingSpace);
            }

        }

        public void ShowList()
        {
            foreach (ParkingSpace aPart in parking)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("------------------");
        }

        public void ShowState()
        {
            for (int i = 0; i < maxCount; i++)
            {
                string var = "busy";
                if (parking[i].isFree)
                {
                    var = "free";
                }

                Console.WriteLine("place #" + (i+1) + " is " + var);
            }
        }
    }
}
