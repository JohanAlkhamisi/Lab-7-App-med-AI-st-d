using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace Lab_7_App_med_AI_stöd
{
    internal class QuizGame
    {

        public void Play()
        {
            // ai helped me move the game logic to a seperat class
            int questionCounter = 0;
            int score = 0;
            Random choicePlacement = new Random();

            //ai helped me change how the loop ends. It stops when there are no more questions
            while (questionCounter < Question.Questions.Count)

            {
                //ai helped me understand why the same answers kept showing. i moved this code inside the loop to get new questions and answers
                string question = Question.Questions[questionCounter];
                string answer = Question.Answers[questionCounter];
                string wrongAnswer1 = Question.WrongAnswer1[questionCounter];
                string wrongAnswer2 = Question.WrongAnswer2[questionCounter];

                //add two wrong answers to the list 
                List<string> options = new List<string>
                {
                    wrongAnswer1, wrongAnswer2
                };

                //put correct answer in random place
                int correctPosition = choicePlacement.Next(0, 3);
                options.Insert(correctPosition, answer);

                //show qustion and answers
                Console.WriteLine($"Question {questionCounter + 1} of {Question.Questions.Count}");
                Console.WriteLine(question);
                Console.WriteLine($"1. {options[0]}");
                Console.WriteLine($"2. {options[1]}");
                Console.WriteLine($"3. {options[2]}");
                Console.WriteLine("Choose 1, 2 or 3");

                int userAnswer;
                
                // ask again if user not enter 1,2,3
                while (!int.TryParse(Console.ReadLine(), out userAnswer)
                       || userAnswer < 1 || userAnswer > 3)
                {
                    Console.WriteLine("Please enter 1, 2 or 3.");
                }

                //add 1 because list starts 0, but answer starts 1
                if (userAnswer == correctPosition + 1)
                {
                    Console.WriteLine("Correct! You earned 1 point.");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer was {answer}.");
                }

                // go to next question
                questionCounter++;

                Console.WriteLine("---------------------");


                
            }

            //show final score
            Console.WriteLine($"Quiz complete! You scored {score} out of {Question.Questions.Count}.");

        }






    }
}
