using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pergunta, Resposta;
            Console.Write("Qual é a sua pergunta? ");
            Pergunta = Console.ReadLine();
            switch(Pergunta);
            {
                case "Conheces o João?":
                    response = "Aquele Falso?";
                case "Mayonese é um instrumentos?":
                    response = "Não Patrick, Mayonese não é um instrumento";
                case "Quais são seus planos para dominação mundial?":
                    response = "Controle sob objetos de dependencia física e emocional humana.";
                case "Quem é você?":
                    response = "I'm Batman";
            }
        }
    }
}
