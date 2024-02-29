using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro não negativo:");
            string resposta = Console.ReadLine();
            byte guardado = byte.Parse(resposta);
            Console.WriteLine(--guardado);
            Console.WriteLine(++guardado);
            Console.WriteLine(guardado/2);
            Console.WriteLine(guardado<<3);
            Console.WriteLine(guardado^5);
            Console.WriteLine(guardado>10);
        }
    }
}
