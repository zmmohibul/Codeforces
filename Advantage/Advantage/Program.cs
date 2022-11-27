using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Linq;


namespace Advantage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                int n = int.Parse(Console.ReadLine());

                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                int max = int.MinValue;
                int secondMax = int.MinValue + 1;

                for (int j = 0; j < arr.Length; j++)
                {
                    int num = arr[j];
                    if (num > max)
                    {
                        secondMax = max;
                        max = num;
                    }
                    else if (num > secondMax)
                    {
                        secondMax = num;
                    }
                }

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < arr.Length; j++)
                {
                    int num = arr[j];
                    if (num != max)
                    {
                        sb.Append($"{num - max} ");
                    }
                    else
                    {
                        sb.Append($"{num - secondMax} ");
                    }
                }

                sb.Remove(sb.Length - 1, 1);
                Console.WriteLine(sb.ToString());
            }
        }
    }
}