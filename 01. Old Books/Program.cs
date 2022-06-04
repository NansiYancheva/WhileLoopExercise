using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            //INPUT
            string searchedBook = Console.ReadLine();
            int numBooks = 0;
            string currBook;
            //ACTIONS
            while ((currBook = Console.ReadLine()) != "No More Books")
            {
                
                if (searchedBook == currBook)
                {
                    Console.WriteLine($"You checked {numBooks} books and found it.");
                    return;
                }
                numBooks++;
            }
            //OUTPUT
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {numBooks} books.");
        }
    }
}
