// This class handles the random number generating, file creating, and Array/Linked List creation

using System;
using System.IO;

namespace algorithmsExcercises
{
    class NumberGenerator
    {
        private Random randnum = new Random();
        private StreamWriter sw = new StreamWriter("../../random.txt");

        //Fills 'random.txt' with 1000 random numbers
        public void Generate()
        {
            using (sw)
            {
                for (int i = 0; i < 1000; i++)
                {
                    sw.WriteLine(randnum.Next(1, 1000));
                }
            }
        }

        //Overwrites random.txt file with new numbers
        public void Generate(Boolean overwrite)
        {
            if (overwrite == false)
                return;
            else
            {
                using (sw = new StreamWriter("../../random.txt", false))
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        sw.WriteLine(randnum.Next(1, 1000));
                    }
                }
            }
        }

        //Creates an Array with current 'random.txt'
        public int[] ReturnArray()
        {
            using (sw)
            {
                string fileContent = File.ReadAllText(@"../../random.txt");

                string[] integerString = fileContent.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                int[] integers = new int[integerString.Length];

                for (int i = 0; i < integerString.Length; i++)
                {
                    integers[i] = int.Parse(integerString[i]);
                }

                return integers;
            }
        }
    }
}