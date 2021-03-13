using System;
using System.Collections.Generic;
using System.Text;

namespace Rolling_a_Dice
{
    class Dice
    {
       public event EventHandler TwoFiveRow;
       public event EventHandler SumGreatherOrEqual;
        public void EventOne()
        {
            TwoFiveRow(this, EventArgs.Empty);
        }
        public void EventTwo()
        {
            SumGreatherOrEqual(this, EventArgs.Empty);
        }
        public static List<int> SuccessiveRolls = new List<int>();
        public static void Rolling(int number)
        {
            SuccessiveRolls.Add(number);
        }
    }
}
