using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            //INPUT
            double change = double.Parse(Console.ReadLine());
            double lv = Math.Floor(change);
            double moneti = Math.Round((change - lv) * 100);
            int totalCoins = 0;
            while (change > 0)
            {
                if (lv >= 2)
                {
                    totalCoins++;
                    lv -= 2;
                }
                else if (lv == 1)
                {
                    totalCoins++;
                    lv -= 1;
                }
                
               if (moneti >= 50)
                {
                    totalCoins++;
                    moneti -= 50;
                }
               else if (moneti >= 20)
                {
                    totalCoins++;
                    moneti -= 20;
                }
                else if (moneti >= 10)
                {
                    totalCoins++;
                    moneti -= 10;
                }
                else if (moneti >= 5)
                {
                    totalCoins++;
                    moneti -= 5;
                }
                else if (moneti >= 2)
                {
                    totalCoins++;
                    moneti -= 2;
                }
                else if (moneti >= 1)
                {
                    totalCoins++;
                    moneti -= 1;
                    break;
                }    
               else
                {
                    break;
                }
            }
            Console.WriteLine(totalCoins);
        }
    }
}
