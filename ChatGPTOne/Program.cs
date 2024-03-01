using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pergunta;
            string Resposta;
            do
            {
                Console.Write("Qual é a sua pergunta? ");
                Pergunta = Console.ReadLine();
                switch (Pergunta)
                {
                    case "Conheces o João?":
                        Resposta = "Aquele Falso?";
                        return Resposta;
                    case "Mayonese é um instrumentos?":
                        Resposta = "Não Patrick, Mayonese não é um instrumento";
                        return Resposta;
                    case "Quais são seus planos para dominação mundial?":
                        Resposta = "Controle sob objetos de dependencia física e emocional humana.";
                        return Resposta;
                    case "Quem é você?":
                        Resposta = "I'm Batman";
                        return Resposta;
                    case "EXIT":
                        break;
                    default:
                        Resposta = "Eu sei lá";
                        return Resposta;
                }
                
                Console.WriteLine(Resposta);

                
            } while (true);
        }
    }
}


