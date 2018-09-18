using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("First");
            q.Enqueue("Second");
            q.Enqueue("Third");
            q.Enqueue("Fourth");
            Console.WriteLine("Queue:");

            while (q.Count > 0)
            {
                object ob = q.Dequeue();

                Console.WriteLine(ob);
            }

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            Console.WriteLine("Stack:");
            while (stack.Count > 0)
            {
                object ob = stack.Pop();
                Console.WriteLine(ob);
            }


            Console.ReadKey();
        }
    }
}
