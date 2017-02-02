using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._0
{
    class NRtLC
    {
        public int Min { get; set; }

        public int Max { get; set; }

        public void Compute(int min = 0, int max = 0)
        {
            int size = (max - min) + 1;

            int[] array = new int[max + 1];
            // IList<int> List = new List<int>(max + 1);
            Stack<int> NumStack = new Stack<int>(size);

            ulong counter = 0;

            for (int i = min - 1; i <= size; i++)
            {

                // array[i] = i; // assigns numbers min to max to an array    <--- Cant handle negatives
                //List.Add(i);                                              <--- Cant handle negatives
                NumStack.Push(i); // add numbers to the stack
            }

            for (int i = min; i <= size; i++)
            {
                // int number = array[i];
                //  int number = List.ElementAt(i);
                int number = NumStack.Pop(); // saves number from the stack to be converted to words

                string word = NumberToWords.NumberToWord(number);

                counter += (ulong)word.Length;  // Counts the number of charaters for each word

            }

            Console.Write($"NRtLC: {counter}"); // Displays number of characters used

        }

        public override string ToString()
        {
            return $"{Min} {Max}";
        }
    }
}
