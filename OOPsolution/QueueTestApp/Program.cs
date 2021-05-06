using System;
using System.Collections;

namespace QueueTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 스택큐 로직 영역

            Console.WriteLine("Queue 테스트"); //큐 구현

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Stack 테스트"); //스택 구현
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()}\t");
            }
            Console.WriteLine();

            #endregion 
            
            //사전
            Hashtable dictionary = new Hashtable();
            /*dictionary["book"] = "책";
            dictionary["cook"] = "요리사";
            dictionary["tweet"] = "지저귀다";
            dictionary["whale"] = "고래";
            Console.WriteLine(dictionary["tweet"]);*/

            dictionary[1] = "책";
            dictionary[2] = "요리사";
            dictionary[3] = "지저귀다";
            dictionary[4] = "고래";
            Console.WriteLine(dictionary[3]);

            

        }
    }
}
