using System;
using System.Threading;

namespace SV1DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AnswerCreator answerCreator = new AnswerCreator();

            Console.Write("Enter your question or leave empty for random answer: ");

            while (true)
            {
                string question = Console.ReadLine();

                if (String.IsNullOrEmpty(question))
                {
                    Console.Write(answerCreator.createRandomAnswer());
                }
                else if (question.Equals("exit"))
                {
                    Console.Write("\n");
                    Console.Write("Exit");
                    return;
                }
                else
                {
                    Console.Write(answerCreator.createConcreteAnswer(question));
                }

                Console.Write("\n");
                Console.Write("Enter your question or leave empty for random answer: ");
            }
        }
    }
}
