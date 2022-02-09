using System;
using System.Collections.Generic;
using System.IO;

namespace DanielPersonalityQuiz
{
    class TestGetResult
     {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-04):
            // For this test, you want to call the GetResult method.
            // 1. First, update GetResult in Program.cs to be public: `public static string GetResult(List<int> Scores, List<string> Results)`
            //
            // This method has 2 parameters List<int> Scores and List<string> Results.
            // The goal of this test is to check and see if this method works as expected.
            // Start by constructing a List<int> to create some test scores:

            // 1. Add `using System.Collections.Generic;` to the top of this file. This will allow you to use the List type.
            // 2. Create a variable called `testScores` that is a list of integers (`List<int>`):

            List<int> testScores;

            // 3. Assign testScores to be a new list of integers:

            testScores = new List<int>();

            // 4. Add a few test values to the list:

            testScores.Add(3);
            testScores.Add(5);
            testScores.Add(1);

            // 5. Create a variable called testResults` that is a list of strings (`List<string>`):

            List<string> testResults;

            // 6. Assign testResults to be a new list of strings:

            testResults = new List<string>();

            // 7. Add a few test values to the list:

            testResults.Add("Spiderman"); // A score of 3 because testScores has 3 in it
            testResults.Add("Black Widow"); // A score of 5 because testScores has a 5 in it
            testResults.Add("The Hulk"); // A score of 1 because testScores has a score of 1 in it

            // 8. Call GetResult and pass the arguments testScores and testResults

            string result = Program.GetResult(testScores, testResults);

            // 9. Check to see if the result was **not** what you expected. In this case, Black Widow should be the winner

            if (result != "Black Widow")
            {
                // 10. If the result is not what we expected, we display a failure message and return false
                Console.Error.WriteLine($"Failure: Expected result to be Black Widow but it was {result}");
                return false;
            }

            // TODO(jcollard 2022-02-03): Write at least 3 more test cases.
            // * What should happen if there is a tie?
            // * What should happen if there are more than 3 possible outcomes?
            // * What other cases might there be?
            testScores = new List<int>();
            testScores.Add(4);
            testScores.Add(4);
            testScores.Add(3);

            testResults = new List<string>();
            testResults.Add("Iron Man");
            testResults.Add("Batman");
            testResults.Add("Superman");

            string result2 = Program.GetResult(testScores, testResults);

            if (result2 != "Iron Man")
            {
                Console.Error.WriteLine($"Failure: Expected result to be Iron Man but it was {result2}");
                return false;
            }
            
            testScores = new List<int>();
            testScores.Add(0);
            testScores.Add(4);
            testScores.Add(3);
            testScores.Add(5);
            
            testResults = new List<string>();
            testResults.Add("Paris");
            testResults.Add("Miami");
            testResults.Add("Los Angeles");
            testResults.Add("New York");

            string result3 = Program.GetResult(testScores, testResults);

            if (result3 != "New York")
            {
                Console.Error.WriteLine($"Failure: Expected result to be New York but it was {result3}");
                return false;
            }
            
            testScores = new List<int>();
            testScores.Add(4);
            testScores.Add(3);

            testResults = new List<string>();
            testResults.Add("Honda");
            testResults.Add("Toyota");
            testResults.Add("BMW");

            try
            {
                Program.GetResult(testScores, testResults);

                Console.Error.WriteLine(" I expected there to be an error but there was not");
                return false;
            }
            catch
            {
            
            }


            // TODO(jcollard 2022-02-03): Finally, if all of the results are as expected, you should return true.
            return true;
        }
    }
}
