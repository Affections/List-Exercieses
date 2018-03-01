using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_for_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();    
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = numbers.Count - 1; i >= secondNumbers[0]; i--)
            {
                numbers.RemoveAt(i);
            }
            for (int i = 0; i < secondNumbers[1]; i++)
            {
                numbers.RemoveAt(i);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == secondNumbers[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");

           
        }
       
    }
}
