using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_4
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Варіант 4
            {
                //task 1
                int[] array = new int[12];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0,20);
                }
                Console.WriteLine("Вихідний масив: " + string.Join("; ", array));
                int k = 0;
                double sum = 0;
                foreach(int j in array)
                {
                    if (j % 3 == 0 )
                    {
                        sum += j;
                        k+=1;
                    }                
                }
                if (k == 0)
                {
                    Console.WriteLine("В масиві чисел, кратних трьом немає");
                }
                else 
                {
                    Console.WriteLine($"Середнє арифметичне чисел, кратних трьом "
                        + Math.Round( sum / k, 3) );
                }  
                Console.WriteLine();
                Console.ReadLine();
            }

            {
                // task 2
                Console.Write("Введіть довжину масиву: ");
                int length = int.Parse(Console.ReadLine());
                int[] array = new int[length];
                Random rand = new Random();
                for (int i = 0; i < length; i++)
                {
                    array[i] = rand.Next(-10, 20);
                }
                Console.WriteLine("Вихідний масив: " + string.Join("; ", array));
                int count = 0;
                for (int i = 0; i < length - 1; i++)
                {
                    if ((array[i] > 0 && array[i + 1] < 0) || (array[i] < 0 && array[i + 1] > 0))
                    {
                        count++;
                        Console.WriteLine($"Пара з протилежними знаками: {array[i]} (індекс {i})" +
                            $" та {array[i + 1]} (індекс {i + 1})");
                    }
                }
                Console.WriteLine($"Кількість пар з протилежними знаками: {count}");
                Console.ReadLine();
            }
        }
    }
}
