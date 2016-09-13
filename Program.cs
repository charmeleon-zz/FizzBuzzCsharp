using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int Counter = 1; Counter <= 100; Counter++)
            {
                String BufferString = "";
                if (0 == Counter % 3) {
                    BufferString += "Fizz";
                }
                if (0 == Counter % 5) {
                    BufferString += "Buzz";
                }
                if (String.IsNullOrEmpty(BufferString)) {
                    BufferString += Counter.ToString();
                }
                Console.WriteLine(BufferString);
            }
        }
    }
}
