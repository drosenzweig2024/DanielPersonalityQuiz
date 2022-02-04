using System;
using System.IO;

namespace DanielPersonalityQuiz
{
    class TestGetResult
     {
        public static bool RunTest()
        {
           Console.WriteLine("The method should validate the users answer to the question");
           Console.WriteLine("Display message prompting user to answer");
           Console.WriteLine("Store users response");
           Console.WriteLine("Validate users choice");
           Console.WriteLine("The number 5 is not valid");
           Console.WriteLine("Letters [A], [B], [C], and [D} are valid");
           int result = Program.GetResult("What is your answer");

            return false;
        }
    }
}
