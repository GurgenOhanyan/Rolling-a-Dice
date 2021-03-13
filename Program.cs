using System;

namespace Rolling_a_Dice
{
    class Program
    {
        static void PrintEvent_1(object sender, EventArgs e)
        {
            int count = 0;
            for (int i =0; i <Dice.SuccessiveRolls.Count-1; i++)
            {
                if (Dice.SuccessiveRolls[i] == Dice.SuccessiveRolls[i+ 1] && Dice.SuccessiveRolls[i] == 5)
                {
                    count++;
                }
            }
            if (count == 0)
            {
             
            }
            else
            {
                Console.WriteLine($"Two fives in a row appeared {count} time");
            }
        }
        static void PrintEvent_2(object sender, EventArgs e)
        {
            int TopFiveIsBig = 0;
            for (int i = 0, j = 5; j < Dice.SuccessiveRolls.Count; i++, j++)
            {
                int sum = 0;
                for (int k = i; k < j; k++)
                {
                    sum += Dice.SuccessiveRolls[k];
                }
                if (sum >= 21)
                {
                    TopFiveIsBig++;
                }
            }
            Console.WriteLine($"There are {TopFiveIsBig} toss sequences with an overall sum greaterthan or equal 21");
        }
            
          static void Main(string[] args)
          {
                Random rnd = new Random();
                for (int i = 0; i < 40; i++)
                {
                    Dice.Rolling(rnd.Next(1, 7));
                }
             foreach (var item in Dice.SuccessiveRolls)
             {
                Console.Write(item+"  ");
             }
             Console.WriteLine();
             Dice obj = new Dice();
             obj.TwoFiveRow += PrintEvent_1;
             obj.EventOne();
             obj.SumGreatherOrEqual += PrintEvent_2;
             obj.EventTwo();
             Console.ReadKey();
          }
        
    }
}
