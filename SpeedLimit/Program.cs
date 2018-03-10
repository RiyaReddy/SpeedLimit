using System;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
                Console.WriteLine("OK");
            else
            {
                const int kmph = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmph; //For every 5km above speed limit 1 demirit point added
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}
