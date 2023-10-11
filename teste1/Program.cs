using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inteiros = { 1, 2, 3, 4, 5, 6 };
            foreach (int i in inteiros)
                Console.WriteLine(i);
            double[] reais = new double [5];
            reais[0] = 24d;
            reais[1] = 24.65d;
            reais[2] = 45.9d;
            reais[3] = 22d;
            reais[4] = 221.1d;
            foreach (double i in reais)
                Console.WriteLine(i);
            string[] palavras = new string[] { "abc", "def", "ghi", "opq" };
            foreach (string i in palavras)
                Console.WriteLine(i);
            Console.WriteLine(palavras.Contains("def"));
            Console.WriteLine(palavras.Length);
            int[,] multinteiros = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };    
            Console.WriteLine(multinteiros[1,1]);
            int[][] jinteiros = new int[3][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
            Console.WriteLine(jinteiros[0][2]);
            Console.ReadLine();
        }
    }
}
