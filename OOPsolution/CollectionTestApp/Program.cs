using System;
using System.Collections;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //박싱/언박싱
            /*int a = 123;
            object obj = (object)a;
            int b = (int)obj;

            Console.WriteLine("a의 값 : " + a);
            Console.WriteLine("obj의 값 : " + obj);
            Console.WriteLine("b의 값 : " + b);

            string str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 : " + str);
            Console.WriteLine("obj의 값 : " + obj);*/

            /*Console.WriteLine("a의 타입 : " + a.GetType());
            Console.WriteLine("ob의 타입 : " + obj.GetType());*/

            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList(); //사이즈 지정 X
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            
            list.Sort(); //오름차순
            foreach (var item in list)
            {
                Console.Write($"{item}\t"); //sorting 하려면 같은 타입이어야 됌 (int,float,double)
            }
            Console.WriteLine();

            list.Reverse(); //내림차순
            foreach (var item in list)
            {
                Console.Write($"{item}\t"); 
            }
            Console.WriteLine();

            list.Add(100); //마지막에 100추가
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Insert(2, 88); //두번째 인덱스에 88추가
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(5); //5번인덱스 제거
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100); //100의 인덱스 위치
            Console.WriteLine($"100의 위치 : {index100}");

            list.Remove(88); //값 88을 제거
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(14);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index14 = list.IndexOf(14); //처음 14의 인덱스 값
            Console.WriteLine($"14의 위치값 : {index14}");

            
            int lstIndex14 = list.LastIndexOf(14); //마지막 14의 인덱스 값
            Console.WriteLine($"마지막 14의 위치값 : {lstIndex14}");

            Console.WriteLine($"총 갯수 : {list.Count}"); //array의 총 갯수

            Console.WriteLine($"리스트 마지막 값 : {list[list.Count - 1]}"); //리스트의 마지막 값
        }
    }
}
