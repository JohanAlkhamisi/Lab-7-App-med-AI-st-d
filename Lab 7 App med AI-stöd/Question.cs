using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_App_med_AI_stöd
{
    internal class Question
    {
        
        //each question and answer has same place in the lists also all lists must have same number of item.
        // 
        //ai suggested using properties but i kept my four lists because i understood this better
        // 
        public static List<string> Questions = new List<string>
        {
            "What is the capital of Sweden?",
            "What is 9 × 6?",
            "Which is the largest planet in the solar system?",
            "Which country has Paris as its capital?",
            "Which century does the year 1789 belong to?"

        };


        public static List<string> Answers = new List<string>
        {
            "Stockholm",
            "54",
            "Jupiter",
            "France",
            "18th century"
        };


        public static List<string> WrongAnswer1 = new List<string>
        {
            "Gothenburg",
            "48",
            "Earth",
            "Italy",
            "17th century"

        };

        public static List<string> WrongAnswer2 = new List<string>
        {
            "Malmö",
            "56",
            "Saturn",
            "Spain",
            "19th century"

        };


      


    }
}
