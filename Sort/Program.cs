using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            Console.WriteLine("До сортировки");
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = Int32.Parse(Console.ReadLine());
                arr[i] = random.Next(0, 100);
                Console.WriteLine(arr[i]);
            }

            // Пузырьковая сортировка,сразу реализована на убывание,ради скорости
            int temp;
            for (int i = arr.Length-1; i>=0; i--)
            {
                //Пропускает сортировку,если элемент меньше 14,тем самым поднимаем скорость алгоритма
                if (arr[i] > 14)
                {
                    for (int j = i - 1; j >=0; j--)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            //Быстрый способ реализации сортировки
            //Array.Sort(arr);
            //Array.Reverse(arr);

            // вывод
            Console.WriteLine("\nПосле сортировки");
            for (int i = 0; i < arr.Length; i++)
            {
                //Пропускаем неотсортированное 
                if (arr[i] > 14)
                {
                    Console.WriteLine(arr[i]);
                }
            }   
        }
    }
}
