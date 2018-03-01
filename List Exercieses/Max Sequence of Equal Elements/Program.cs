using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 1;
            int realNumber = 0;
            int tempNumber= 0;
            int longestCount = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 != numbers.Count)
                {
                    tempNumber = i;
                    while (numbers[i] == numbers[i + 1])
                    {
                       
                        count++;
                        i++;
                        if (i + 1 != numbers.Count)
                        {
                            continue;
                        }
                        else
                        {
                        
                            if (count > longestCount)
                            {
                                realNumber = tempNumber;
                                longestCount = count;
                            }
                            for (int  c= 0; c < longestCount; c++)
                            {
                                Console.Write(numbers[realNumber] + " ");
                            }
                            return;
                        }
                    }
                    if (count>longestCount)
                    {
                        realNumber = tempNumber;
                        longestCount = count;
                    }
                    count = 1;
                }
                else
                {

                    if (count > longestCount)
                    {
                        realNumber = tempNumber;
                        longestCount = count;
                    }
                    for (int c = 0; c < longestCount; c++)
                    {
                        Console.Write(numbers[realNumber] + " ");
                    }
                    return;
                }

            }
        }
    }
}
