using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace GenericQueuePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericQueue<int> numbersQ = new GenericQueue<int>();
            Console.WriteLine($"GenericQueue API tester for {numbersQ.GetItemsTypeName()}:");
            Console.WriteLine($"numbersQ.Count={numbersQ.Count}");
            numbersQ.Enqueue(1);
            numbersQ.Enqueue(2);
            numbersQ.Enqueue(3);
            numbersQ.Enqueue(4);
            Console.WriteLine($"numbersQ.Count={numbersQ.Count}");
            Console.WriteLine($"numbersQ.Contains(4)={numbersQ.Contains(4)}");
            Console.WriteLine($"numbersQ.Contains(5)={numbersQ.Contains(5)}");
            Console.WriteLine($"numbersQ.Peek()={numbersQ.Peek()}");
            Console.WriteLine($"numbersQ.Dequeue()={numbersQ.Dequeue()}");
            Console.WriteLine($"numbersQ.Dequeue()={numbersQ.Dequeue()}");
            Console.WriteLine($"numbersQ.Dequeue()={numbersQ.Dequeue()}");
            Console.WriteLine($"numbersQ.Dequeue()={numbersQ.Dequeue()}");
            Console.WriteLine($"numbersQ.Count={numbersQ.Count}");
        }
    }
}
