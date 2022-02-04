using System;
using System.Collections.Generic;
using System.IO;

namespace DanielPersonalityQuiz
{
    class TestGetValidAnswer
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-04): This can be tested very similarly to AskQuestion.
            // This is because AskQuestion uses this method to get a valid answer.
            
            List<string> answers = new List<string>();
            try 
            {
                Program.GetValidAnswer(answers);
                Console.Error.WriteLine($" I expected an exception from passing in a empty list");
                return false;
            }

            catch
            {

            }
           
        
            
            if(result != expected)
            {
                Console.Error.WriteLine($"Expected the result to be {expected} but was {result}");
            }
            return false;
        }
}
}
