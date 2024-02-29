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
        }
    }
}
