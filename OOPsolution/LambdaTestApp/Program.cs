using System;

namespace LambdaTestApp
{
    class Program
    {
        delegate void DoSomething(string name);
        delegate string Concatenate(string[] arr);


        static void Main(string[] args)
        {
            //DoSomething doIt = delegate () // 밑에 거랑 같은 뜻
            /*DoSomething doIt = () =>
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine("John Doe");
            };*/
            DoSomething doIt = (name) =>
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine($"{name}");
                //return; //void이기 때문에 생략가능
            };
            string name = "Hugo";
            doIt(name);

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result;
            };
            string[] strarr = { "아버지가", "방에", "들어가신다" };
            Console.WriteLine(concat(strarr));

            Func<int> fuc1 = () => 3;

            var val = fuc1();
            Console.WriteLine($"val의 값은 { val }");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3+5={plus(3, 5)}");
            
            Action<int> area = (r) => 
            {
                Console.WriteLine($"원의 넒이는{(double) r * r * Math.PI}");
            };
            area(10);
        }
    }
}
//void는 return 안 써도 됌
//string 은 return 써야 됌
