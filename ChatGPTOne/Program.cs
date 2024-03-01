using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string Pergunta;
                string Resposta;
                Console.Write("Qual é a sua pergunta? ");
                Pergunta = Console.ReadLine();
                switch (Pergunta)
                {
                    case "Conheces o João?":
                        Resposta = "Aquele Falso?";
                        continue;
                    case "Mayonese é um instrumentos?":
                        Resposta = "Não Patrick, Mayonese não é um instrumento";
                        continue;
                    case "Quais são seus planos para dominação mundial?":
                        Resposta = "Controle sob objetos de dependencia física e emocional humana.";
                        continue;
                    case "Quem é você?":
                        Resposta = "I'm Batman";
                        continue;
                    case "EXIT":
                        break;
                    default:
                        Resposta = "Eu sei lá véi";
                        continue;
                }
                Console.WriteLine(Resposta);

                
            } while (true);
        }
    }
}


