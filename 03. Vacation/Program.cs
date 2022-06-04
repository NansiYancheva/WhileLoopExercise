using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            //INPUT
            double moneyNeededForTheTrip = double.Parse(Console.ReadLine());
            double savings = double.Parse(Console.ReadLine());
            int totalDays = 0;
            int seqDays = 0;

            //ACTIONS
            while (savings < moneyNeededForTheTrip)
            {
               string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                totalDays++;
                if (action == "spend")
                {
                    seqDays++;
                    savings -= currentMoney;
                    if (seqDays >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(totalDays);
                        return;
                    }
                    if (savings < 0)
                    {
                        savings = 0;
                    }

                }
                else if (action == "save")
                {
                    savings +=currentMoney;
                    seqDays = 0;
                }


            }

            //OUTPUT
            //след като спестяванията й станат повече от парите за екскурзията (savings > moneyNeededForTheTrip
            Console.WriteLine($"You saved the money for {totalDays} days.");

        }
    }
}

