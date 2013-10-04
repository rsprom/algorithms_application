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

            linkedList.AddToBack('1');
            linkedList.AddToBack('2');
            linkedList.AddToBack('3');
            linkedList.AddToBack('4');
            linkedList.AddToBack('5');
            linkedList.AddToFront('5');

            Console.WriteLine(linkedList.ToString());

        }
    }
}
