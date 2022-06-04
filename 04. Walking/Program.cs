using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            //INPUT
            string input;
            int totalSteps = 0;

            while ((input = Console.ReadLine()) != "Going home")
            {
                int stepsPerOneTime = int.Parse(input);
                totalSteps += stepsPerOneTime;
                if (totalSteps >= 10000)
                {
                    int differenceAboveGoal = Math.Abs(totalSteps - 10000);
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{differenceAboveGoal} steps over the goal!");
                    return;
                }
            }
            int finalStepsTaken = int.Parse(Console.ReadLine());
            int differenceFinal = Math.Abs((totalSteps + finalStepsTaken) - 10000);
            if (totalSteps + finalStepsTaken >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{differenceFinal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{differenceFinal} more steps to reach goal.");
            }

        }
    }
}

