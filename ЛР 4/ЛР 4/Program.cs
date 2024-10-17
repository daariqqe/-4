using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Варіант 4
            {
                //task 1                 
                int[] array = new int[11];
                Random random = new Random();
                Console.WriteLine("Вхідний масив");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0,20);
                    Console.Write(i + " ");
                }
                int k = 0;
                int sum = 0;
                foreach(int j in array)
                {
                    if (j % 3 == 0 )
                    {
                        sum += j;
                        k+=1;
                    }                
                }
                if (sum == 0 && k == 0)
                {
                    Console.WriteLine("В масиві чисел кратних трьом немає");
                }
                else 
                {
                    Console.WriteLine(sum / k);
                }            
                Console.ReadLine();
            }
        }
    }
}
