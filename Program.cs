using System;
using System.Collections.Generic;
using System.IO;
namespace myConsoleApp1
{
    class Program
    {

        /* Update your program so it picks a random question from a set of at least 3,
        and so that it gives positive/negative answers that correspond to each question accordingly */

        static List<QuestionAnswer> ListQuestionAnswers()
        {
            // string[] questions = { "Is pineapple OK on pizza?", "Is it ok to leave the teabag in?", "Is c# difficult?" };

            var questionAnswers = new List<QuestionAnswer>();
            questionAnswers.Add(new QuestionAnswer()
            {
                Question = "Is pineapple OK on pizza?",
                NegativeAnswer = "Damn straight",
                PositiveAnswer = "You sicken me",
                NotAnAnswerAnswer = "That's not an answer you mongrel"
            });
            questionAnswers.Add(new QuestionAnswer()
            {
                Question = "Is it ok to leave the teabag in?",
                NegativeAnswer = "Your family are dissapointed in you",
                PositiveAnswer = "Get the kettle on then skip"
            });
            questionAnswers.Add(new QuestionAnswer()
            {
                Question = "Is c# difficult?",
                NegativeAnswer = "You're a liar, liar",
                PositiveAnswer = "I hear ya brother"
            });

            //questionAnswers.Add("DAFADF");


            // return the questions
            return questionAnswers;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello, {userName}");
            Console.WriteLine();
            Console.WriteLine("Are you having a good day? \nEnter Y/N");

            var input = Console.ReadKey().Key;
            Console.WriteLine();
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.Y:
                    Console.WriteLine($"\nGood shit {userName}");
                    break;
                case ConsoleKey.N:
                    Console.WriteLine($"\nAh balls, you suck {userName}");
                    break;
                default:
                    Console.WriteLine($"\nType something proper ya idiot .");
                    break;
            }

            // get questions
            List<QuestionAnswer> questionAnswers = ListQuestionAnswers();


            // loop forever until the user presses Q for Quit
            while (true)
            {


                // pick a random one
                Random rnd = new Random();
                int questionNumber = rnd.Next(questionAnswers.Count);

                // i have a number between 1 and 3
                var questionAnswerToAsk = questionAnswers[questionNumber];

                // i have one question. ask it
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(questionAnswerToAsk.Question);
                Console.WriteLine("(answer with a Y or N, or press Q to quit)");

                var answer = Console.ReadKey().Key;

                // here's where i break, if they type Q
                if (answer == ConsoleKey.Q)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("See ya");
                    Console.WriteLine();
                    break;
                }


                Console.WriteLine();
                Console.WriteLine();
                if (answer == ConsoleKey.Y)
                {
                    Console.WriteLine(questionAnswerToAsk.PositiveAnswer);
                }
                else if (answer == ConsoleKey.N)
                {
                    Console.WriteLine(questionAnswerToAsk.NegativeAnswer);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(questionAnswerToAsk.NotAnAnswerAnswer))
                    {
                        // this wil never be called now as set when object is created in constructor
                        Console.WriteLine("That's not an answer, douchebag");
                    }
                    else
                    {
                        Console.WriteLine(questionAnswerToAsk.NotAnAnswerAnswer);
                    }
                }
            }


            // switch (input)
            // {
            //     case ConsoleKey.Y:
            //     case ConsoleKey.Q:
            //         Console.WriteLine(questionAnswerToAsk.PositiveAnswer);
            //         break;
            //     case ConsoleKey.N:
            //         Console.WriteLine(questionAnswerToAsk.NegativeAnswer);
            //         break;
            //     default:
            //         Console.WriteLine("That's not an answer, douchebag");
            //         break;
            // }

            // for (int i = 1; i < 100; i++)
            // {
            //     Console.WriteLine(i);
            //     if (i == 42)
            //     {
            //         break;
            //     }
            // }

        }
    }
}