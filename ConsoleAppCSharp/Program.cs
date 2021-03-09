using System;
using ClassLibraryFSharp;

namespace ConsoleAppCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Инициализация Random'а
                Random MyRandom = new Random();

                //Количество элементов в массиве
                int n = MyRandom.Next(1, 21);

                //Исходный массив
                int[] MyArray = new int[n];

                //Заполнение массива
                for (int i = 0; i < n; i++)
                    MyArray[i] = MyRandom.Next(-20, 21);

                //Вывод состояния массива до сортировки
                Console.WriteLine("Source array:");
                foreach (int x in MyArray)
                {
                    Console.Write(" " + x);
                }

                //Вызов метода QuickSort из модуля MyModule в ClassLibraryFSharp
                MyArray = MyModule.QuickSort(MyArray);

                //Вывод состояния массива после сортировки
                Console.WriteLine("\nSorted array:");
                foreach (int x in MyArray)
                {
                    Console.Write(" " + x);
                }
            }
            catch (Exception ex)
            {
                //Вывод сообщения об ошибке
                Console.WriteLine("Error! Message: " + ex);
            }

            //Консолька в режиме ("ожидания")
            Console.ReadKey();
        }
    }
}
