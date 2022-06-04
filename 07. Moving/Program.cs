using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            
            int widthFreePlace = int.Parse(Console.ReadLine());
            int lenghtFreePlace = int.Parse(Console.ReadLine());
            int hightFreePlace = int.Parse(Console.ReadLine());
            int totalFreePlace = widthFreePlace * lenghtFreePlace * hightFreePlace;
            string comand;

            while ((comand = Console.ReadLine()) != "Done")
            {
                int boxes = int.Parse(comand);
                totalFreePlace -= boxes;

                if (totalFreePlace < 0)
                {
                    break;
                }
            }
            if (totalFreePlace < 0)
            {
                int remainingPlace = Math.Abs(totalFreePlace);
                Console.WriteLine($"No more free space! You need {remainingPlace} Cubic meters more.");

            }
            else
            {
                int remainingPlace = Math.Abs(totalFreePlace);
                Console.WriteLine($"{remainingPlace} Cubic meters left.");
            }


        }
    }
}

