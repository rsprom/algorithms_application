// This class handles the random number generating, file creating, and Array/Linked List creation

using System;
using System.IO;

namespace algorithmsExercises
{
    class NumberGenerator
    {
        private Random randnum; 
        private StreamWriter sw; 

        //Constructs class
        public NumberGenerator()
        {
            randnum = new Random();
            sw = new StreamWriter("../../random.txt");
            sw.Close();
        }

        //Fills 'random.txt' with random numbers
        public void Generate(int amount)
        {
            using (sw = new StreamWriter("../../random.txt", false))
            {
                for (int i = 0; i < amount; i++)
                {
                    sw.WriteLine(randnum.Next(1, 9999));
                }
            }
        }

        //Creates an Array with current 'random.txt'
        //Adds to array from the back for consistancy with ReturnLinkedList method
        public int[] ReturnArray()
        {
            using (sw)
            {
                string fileContent = File.ReadAllText(@"../../random.txt");
                string[] integerString = fileContent.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerString.Length];
                for (int i = integerString.Length - 1; i > 0; i--)
                {
                    integers[i] = int.Parse(integerString[i]);
                }

                return integers;
            }
        }

        //Creates a LinkedList with current 'random.txt'
        //Adds to list from the front for consistancy with ReturnArray method
        public LinkedList ReturnLinkedList()
        {
            using (sw)
            {
                string fileContent = File.ReadAllText(@"../../random.txt");
                string[] integerString = fileContent.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                LinkedList list = new LinkedList();
                for (int i = 0; i < integerString.Length; i++)
                {
                    list.AddToFront(integerString[i]);
                }

                return list;
            }
        }
    }
}