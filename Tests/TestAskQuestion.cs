using System;
using System.Collections.Generic;
using System.IO;

namespace DanielPersonalityQuiz
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-04): 
            // This method should test calling the `AskQuestion` method.
            // The `AskQuestion` method has 1 parameter which accepts a `Question` type.

            // 1. Start by creating a Question 
            
            Question question = new Question();
            
            // 2. Set the question
            question.question = "What is your favorite food?";

            // 3. Add some answers to the question
            question.answers.Add("Chicken"); // Index 0
            question.answers.Add("Fish");    // Index 1

            // 4. Display a message to the tester explaining what they should.
            Console.WriteLine("Calling AskQuestion. Expecting to ask 'What is your favorite food?'");

            // 5. Tell the tester to etner some invalid options.
            Console.WriteLine("You should see 2 options. Try an invalid option by typing 3. This should display 'Invalid' and prompt again.");

            // 6. Tell the test to enter a valid input
            Console.WriteLine("Then select a valid option: 2. This should be valid");

            // 7. Finally, call the method
            int result = Program.AskQuestion(question);

            // 8. Assume the tester will follow the instructions. What should the expected result of the method be?
            //    In this case, it should be 1 (e.g. Fish which is at index 1 of the list)
            int expected = 1;

            // 9. Check to see if the result does not match what is expected
            if (result != expected)
            {
                // 10. IF the result does not match, we tell the tester what went wrong:
                Console.Error.WriteLine($"Expected the result to be {expected} but was {result}.");

                // 11. We return false to fail the test
                return false;
            }

            // TODO: Write at least 2 more test cases
            // 1. Test with a list that has more than 3 elements.
            // 2. What are some additional invalid inputs to test?
            // 3. Make sure to test at least 2 more valid inputs


            // TODO(jcollard 2022-02-04): If we make it this far, the test is passing so we return true
            return true;
        }
    }

}
