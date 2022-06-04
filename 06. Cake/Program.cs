using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string comand;
            int totalPieces = lenght * width;
            while ((comand = Console.ReadLine()) != "STOP")
            {
                int takenPieces = int.Parse(comand);
                totalPieces -= takenPieces;

                if (totalPieces < 0)
                {
                    break;
                }
            }
                if (totalPieces < 0)
                {
                    int remainingPieces = Math.Abs(totalPieces);
                    Console.WriteLine($"No more cake left! You need {remainingPieces} pieces more.");
                    return;
                }

            
            Console.WriteLine($"{totalPieces} pieces are left.");
        }
    }
}
