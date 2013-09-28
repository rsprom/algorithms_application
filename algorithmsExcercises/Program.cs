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


            stopwatch.Start();
            newGenerator.Generate(50000);
            Console.WriteLine("Generated");
            linkedList = newGenerator.ReturnLinkedList();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Start();
            newGenerator.Generate(5000000);
            Console.WriteLine("Generated");
            arrayList = newGenerator.ReturnArray();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
