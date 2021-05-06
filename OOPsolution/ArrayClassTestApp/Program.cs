using System;

namespace ArrayClassTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array 클래스 사용");

            int[] array = new int[] { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6 };

            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            System.Array.Sort(array); //오름차순 정렬

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            Array.Reverse(array); //내림차순 정렬
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            int index7 = Array.IndexOf(array, 7);
            Console.WriteLine($"7의 위치는 {index7}"); //index 위치 찾기

            Array.Resize<int>(ref array, 11); //배열 사이즈 늘리기
            array[10] = 100;
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}
