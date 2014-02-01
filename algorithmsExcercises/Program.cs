using System;
using System.Diagnostics;

namespace algorithmsExercises
{
    class Program
    {
        static void Main(String[] arg)
        {
            Stopwatch stopwatch = new Stopwatch();
            NumberGenerator newGenerator = new NumberGenerator();
            LinkedList linkedList = new LinkedList();
            int[] arrayList = new int[0];

            newGenerator.Generate(10);
            linkedList = newGenerator.ReturnLinkedList();

            Console.WriteLine(linkedList.ToString());
            linkedList.PrintBackwards();
            Console.Read();
        }
    }
}
