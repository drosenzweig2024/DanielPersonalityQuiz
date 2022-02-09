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
            Console.WriteLine($" Select an option 1 to {answers}");

            int result = Program.GetValidAnswer(answers);

            int expected = 1;

            if (result != expected)
            {

                Console.Error.WriteLine($"Expected the result to be {expected} but was {result}.");

                return false;
            }

            // TODO(jcolalrd 2022-02-07): This looks great! Add 1 more test
            // case, test invalid input and one more correct input and you'll be
            // golden!

            // TODO(jcollard 2022-02-07): If you make it to the end of this
            // test case, you should return true.
            return true;
        }
    }
}
