using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            //INPUT
            int numberBadGrades = int.Parse(Console.ReadLine());
            string currNameOfTask;
            int currGrade;
            int currBadGrades = 0;
            double totalGrades = 0;
            int totalNumberOfTasks = 0;
            string lastNameOfTask = "";
            //ACTIONS
            while ((currNameOfTask = Console.ReadLine()) != "Enough")
            {
                currGrade = int.Parse(Console.ReadLine());
                totalGrades += currGrade;
                totalNumberOfTasks++;
                lastNameOfTask = currNameOfTask;
                if (currGrade <= 4)
                {
                    currBadGrades++;

                    if (currBadGrades == numberBadGrades)
                    {
                        Console.WriteLine($"You need a break, {currBadGrades} poor grades.");
                        return;
                    }
                }

            }
            double avgGrade = totalGrades / totalNumberOfTasks;
            Console.WriteLine($"Average score: {avgGrade:f2}");
            Console.WriteLine($"Number of problems: {totalNumberOfTasks}");
            Console.WriteLine($"Last problem: {lastNameOfTask}");


        }
    }
}