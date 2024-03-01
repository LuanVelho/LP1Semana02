using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura e o raio de um cilindro");
            Console.Write("Insira a altura: ");
            string altura = Console.ReadLine();
            Console.Write("Insira o raio: ");
            string raio = Console.ReadLine();
            int a = int.Parse(altura);
            int r = int.Parse(raio);
            float Vf = (MathF.PI * MathF.Pow(r,2) * a);
            int V = Convert.ToInt32(Vf);
            Console.WriteLine($"O volume do Cilindro é de {V}");
            float Saf = ((2*MathF.PI*r)*(r+a));
            int Sa = Convert.ToInt32(Saf);
            Console.WriteLine($"A área de superfície do cilindro é {Sa}");

        }
    }
}
