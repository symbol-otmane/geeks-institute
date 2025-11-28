using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var data = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
            new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
            new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
            new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
            new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
            new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
        };

        int correct = 0;
        var wrongAnswers = new List<(string Question, string UserAnswer, string CorrectAnswer)>();

        foreach (var q in data)
        {
            Console.WriteLine(q["question"]);
            string userAnswer = Console.ReadLine();

            if (userAnswer.Trim().Equals(q["answer"], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!\n");
                correct++;
            }
            else
            {
                Console.WriteLine("Wrong!\n");
                wrongAnswers.Add((q["question"], userAnswer, q["answer"]));
            }
        }

        Console.WriteLine($"\nQuiz finished! Correct: {correct}, Incorrect: {wrongAnswers.Count}");

        if (wrongAnswers.Count > 0)
        {
            Console.WriteLine("\nWrong answers details:");
            foreach (var w in wrongAnswers)
                Console.WriteLine($"Q: {w.Question}, Your answer: {w.UserAnswer}, Correct answer: {w.CorrectAnswer}");
        }

        if (wrongAnswers.Count > 3)
        {
            Console.WriteLine("\nYou got more than 3 wrong answers. Try playing again!");
        }
    }
}