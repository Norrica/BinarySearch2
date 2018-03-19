using System;

namespace ConsoleApplication
{
	class Program
		{
		public static int BinarySearch(int[] array, int value)
		{
			if ((array.Length == 0) || (value < array[0]) || (value > array[array.Length - 1]))
			{
				return -1;
			}
			int a = 0;			
			int b = array.Length;
			while (a < b)
			{
				int mid = a + (b - a) / 2;
				if (value <= array[mid])
				{
					b = mid;
				}
				else
				{
					a = mid + 1;
				}
			}
			if (array[b] == value)
			{
				return b;
			}
			else
			{
				return -1;
			}
		}
		static void Main(string[] args)
		{
			TestLargeArrays();
			TestArrayOfCouples();
			TestOneOfFive();
            TestNegativeNumbers();
			TestNonExistentElement();
			Console.ReadKey();
		}
		private static void TestLargeArrays()
		{
			Console.WriteLine("Тестирование поиска в больших массивах");
            int[] a = new int[100001];
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = i;
			}				
			if (BinarySearch(a, 55546) != -1)
			{
				Console.WriteLine("Поиск в большом массиве чисел работает корректно");
			}
			else
			{
				Console.WriteLine("Поиск работает некорректно");
			}		
			
		}
		private static void TestArrayOfCouples()
		{
			Console.WriteLine("\nТестирование поиска среди сдвоенных чисел");
            int[] a = new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 2, 2, 5  };
			if (BinarySearch(a, 2) != 2)
				Console.WriteLine("! Поиск работает некорректно");
			else
				Console.WriteLine("Поиск повторяющихся элементов работает корректно");
		}	
		private static void TestOneOfFive()
		{
			Console.WriteLine("\nТестирование поиска в простом массиве");
            int[] a = new[] { 1, 2, 3, 4, 5 };
			if (BinarySearch(a, 5) != 4)
				Console.WriteLine("! Поиск не нашёл число 3 среди чисел { 1, 2, 3, 4, 5 }");
			else
				Console.WriteLine("Поиск в массиве из 5 чисел работает корректно");
		}
		private static void TestNegativeNumbers()
		{
			Console.WriteLine("\nТестирование поиска в отрицательных числах");
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
			if (BinarySearch(negativeNumbers, -3) != 2)
				Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
			else
				Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
		}
		private static void TestNonExistentElement()
		{
			Console.WriteLine("\nТестирование поиска отсутствующего элемента");
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
			if (BinarySearch(negativeNumbers, -1) >= 0)
				Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
			else
				Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат");
		}
	}
}