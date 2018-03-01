using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split().ToArray();
            int bombNumber = int.Parse(commands[0]);
            int power = int.Parse(commands[1]);
            while (numbers.Contains(bombNumber))
            {
                int position = numbers.IndexOf(bombNumber);
                if(position + power >= numbers.Count && position - power < 0)
                {
                    numbers.Clear();
                }
                else if (position + power >= numbers.Count)
                {
                    numbers.RemoveRange(position - power, power + numbers.Count - position);
                }
                else if (position - power < 0)
                {
                    numbers.RemoveRange(0, 1+power+position);
                }
                else
                {
                    numbers.RemoveRange(position - power, 2 * power + 1);
                }
            }
            Console.WriteLine(numbers.Sum());

        }
    }
}
