using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {// علی پیر محمد جماعت و حمیدرضا واحدی و مهدی نوروزی پیشرفنه 1
            Console.WriteLine("factoriel giri");
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            for(int i = 1; i <= num; i++) 
            { x *= i; }
            Console.WriteLine(x);
            Console.ReadKey();
        }

    }
}
