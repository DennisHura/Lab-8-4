using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace prog_4s_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before");
            int[] arr = System.IO.File.ReadAllText("in.txt").Split(' ').Select(n => int.Parse(n)).ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                numbers.Push(arr[i]);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("after");
            StreamWriter sw = new StreamWriter("out.txt");
            while (numbers.Count != 0)
            {
                int stackElement = numbers.Pop();
                sw.Write(stackElement);
                Console.WriteLine(stackElement);

            }
            sw.Close();

        }
    }
}
