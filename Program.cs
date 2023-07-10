using System.Diagnostics;

namespace Deliverable_2
{
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            bool validEntry = false;

            while (!validEntry)
            {
                try
                {

                    Console.WriteLine("Enter an integer between 5 and 15 ");
                    int input = int.Parse(Console.ReadLine());

                    int[] sampleArray = random_array(input);
                    validEntry = (input >= 5 && input <= 15);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.WriteLine(element + " ");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("The sum is: " + sum(sampleArray));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Entry. Enter integer between 5 and 15!");
                }
            }
        }
    }
}