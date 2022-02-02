using System;
using System.Collections.Generic;
using System.IO;

namespace DanielPersonalityQuiz
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {
            List<string> answers = new List<string>();
            List <string> question = new List<string>(); 
            Console.WriteLine($"The method should display {question}");
            Console.WriteLine($"Display {answers}");
            Console.WriteLine("Type '5' This should display 'Invalid'");
            Console.WriteLine("Type '[A],[B],[C],or [D]' This should be valid");
        
            return false;
        }
    }

}
