using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01Problema03
{
    public class MoneyParts
    {
        
        public void Built(List<double> coins, List<double> amounts, double highest, double sum, double goal)
        {
            // See if we are done.
            if (sum == goal)
            {
                Display(coins, amounts);
                return;
            }
            // See if we have too much.            
            if (sum > goal)
            {
                return;
            }
            // Loop through amounts.            
            foreach (double value in amounts)
            {
                // Only add higher or equal amounts.
                if (value >= highest)
                {
                    List<double> copy = new List<double>(coins);
                    copy.Add(value);
                    Built(copy, amounts, value, sum + value, goal);
                }
            }
        }

        private void Display(List<double> coins, List<double> amounts)
        {
            foreach (double amount in amounts)
            {
                int count = coins.Count(value => value == amount);
                Console.WriteLine("-{0}: {1} vece(s)",
                    amount,
                    count);
            }
            Console.WriteLine();
        }
    }
}
