using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication

{

    class Program

    {

        public static int BinarySearch(int[] array, int value)

        {
            if ((array.Length == 0) || (value < array[0]) || (value > array[array.Length - 1]))
                return -1;
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if ( value<= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array.Length==0||array[right] == value)
            {
                return right;
            }

            return -1;

        }



        static void Main(string[] args)

        {
            TestBigArray();
            TestNegativeNumbers();

            TestNonExistentElement();

            TestExistentElement();
            TestNullNumbers();
            TestRepetition();
            Console.ReadKey();

        }

        private static void TestBigArray()
        {
            int[] numbers = new int[100001];
            for (int i = 0; i < 100001; i++)
                numbers[i] = i;
            if (BinarySearch(numbers, 6) == 6)
                Console.WriteLine("Поиск  массиве из 100001 элементов работает корректно");
            else
                Console.WriteLine("Поиск не нашел числа 6 в массиве из 100001 элемента");
        }

        private static void TestNegativeNumbers()

        {

            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
           
            if (BinarySearch(negativeNumbers, -3) != 2)

                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");

        }

        private static void TestNonExistentElement()

        {

            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат");

        }
        private static void TestExistentElement()

        {

            //Тестирование поиска  элемента из 5 элементов

            int[] negativeNumbers = new[] { 5, 4, 1, 2 , 7 };

            if (BinarySearch(negativeNumbers, -4) ==-4)

                Console.WriteLine("Поиск не нашёл число 1 среди чисел {5, -4, 1 -2,7}");

            else

                Console.WriteLine("Поиск  элемента вернул корректный результат");

        }
        private static void TestNullNumbers()

        {

            //Тестирование поиска в пустом массиве 

            int[] numbers = { };
            if (BinarySearch(numbers, 7) == -1)
                Console.WriteLine("Поиск в пустом массиве работает корректно");
            else
                Console.WriteLine("! Поиск нашел в пустом массиве число 3");
        }
        private static void TestRepetition()
        {
            int[] numbers = new[] { 1, 2, 3, 3, 5 };
            if (BinarySearch(numbers, 5) == 5)
                Console.WriteLine("! Поиск не нашёл число 5 среди чисел {1, 2, 3, 3, 5}");
            else
                Console.WriteLine("Поиск среди положительных чисел с повторениями работает корректно");
        }
    }
   
}
