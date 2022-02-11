using System;
using System.Collections.Generic;

namespace DanielPersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if(args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
            
            
            // Feedback(jcollard 2022-01-28): Daniel, you're off to a great
            // start! I've gone ahead and done a few corrections as well as
            // added a handful of TODO comments. You sould complete the TODO
            // comments before moving on to Part 2.2.

            // Example(jcollard 2022-01-28): Below is an example of using the
            // Question class to create three questions. 

            // Construct a new Question object
            Question woodChuckQuestion = new Question();

            // Next, set the question to be an actual question.
            woodChuckQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";

            // Next, add answers to the question
            woodChuckQuestion.answers.Add("As much wood as a woodchuck could chuck if a woodchuck could chuck wood.");
            woodChuckQuestion.answers.Add("Uh... 14?");
            woodChuckQuestion.answers.Add("None. Clearly the woodchuck is a manifestation of all your fears.");
            
            Question foodQuestion = new Question();

            // Next, set the question to be an actual question.
            foodQuestion.question = "What is your favorite food?";

            // Next, add answers to the question
            foodQuestion.answers.Add("Wood");
            foodQuestion.answers.Add("Woodchuck");
            foodQuestion.answers.Add("Banana water");

            // Displays the wood chuck question
            Console.WriteLine(woodChuckQuestion.question);

            foreach (string answer in woodChuckQuestion.answers)
            {
                Console.WriteLine(answer);
            }

            // Displays the food question
            Console.WriteLine(foodQuestion.question);

            foreach (string answer in foodQuestion.answers)
            {
                Console.WriteLine(answer);
            }


            // TODO(jcollard 2022-02-11): After you have finished all of your
            // methods you need to create a sequence which calls them here.
            // 1. Create all of your questions
            // 2. Create a List<int> scores and set each score to 0.
            // 3. foreach question, call AskQuestion
            // 3  a. Store the result of AskQuestion in a variable called result
            // 3  b. Update scores[result] = scores[result] + 1;
            // 4. Create a List of your results
            // 5. Call GetResults(score, results)
            // 6. Display the results
            
        } 
        
        public static void TestAll()
        {
            bool testAskQuestion = TestAskQuestion.RunTest();
            Console.WriteLine($"test AskQuestion(filename): {testAskQuestion}");

            bool testGetResult = TestGetResult.RunTest();
            Console.WriteLine($"test GetResult(filename): {testGetResult}");

             bool testGetValidAnswer = TestGetValidAnswer.RunTest();
            Console.WriteLine($"test GetValidAnswer(filename): {testGetValidAnswer}");
        }
        
        
        
        
        // I added this curly bracket to end your Main method. Your other methods should be inside the Program class but not inside of this method.
            
            //Display the question to the user
            //Loop through each answer and display it
            //Using the GetValidAnswer method get and return the users response
            /// <summary>
            /// This displays the question and all of the answers and prompts the user to choose one the answers and returns the answer.
            /// </summary>
            /// <param name="question">The question that is being asked</param>
            /// <returns>It returns the answer to the player</returns>
        public static int AskQuestion(Question question) // I added the variable question here.
        {
            // Feedback(jcollard 2022-02-09): Do this method second

            // Here is an exmaple showing how to iterate through a list of
            // options and display them to the console: 
            // https://jcollard.github.io/IntroToCSharpSite/examples/display-options
            
            // TODO(jcollard 2022-02-11): You cannot define a method inside of a
            // method
            // DELETE BELOW THIS LINE

            static void DisplayOptions(List<string> options) 
            {

            // DELETE ABOVE THIS LINE

                // TODO(jcollard 2022-02-11): You should modify this code to use
                // your question and quesiton.answers. This will not work as is
                if(options == null) throw new ArguementNullException("List of options may not be null");
                if(options.Count == 0) throw new ArgumentException("There should be at least 1 option in the list");
                int index = 1;
                foreach (string option in options)
                {
                    Console.WriteLine($"{index}. {option}");
                    index = index + 1;
                }

                // TODO(jcollard 2022-02-11): After you display the options, you
                // need to get a valid answer. This can be done by calling
                // GetValidAnswer and pass in question.answers.
                // You should then return the result of calling that method

            }
            // DELETE BELOW THIS LINE
            static void Main()
            {
                List<string> options = new List<string>();
                options.Add("First Choice");
                options.Add("Second Choice");
                options.Add("Third Choice");
                DisplayOptions(options);
            }
            // DELETE ABOVE THIS LINE

            return -1; 
        }

            //Validate that there is at least 1 possible answer.
            //If the list of answers is empty then throw an exception
            //If not display a message that asks the user to pick an option
            //Store the user's response in a variable name choice
            //Validate that the users choice is one of the possible answers
            //If it is not a valid answer then display an invalid command message
            //Otherwise, return the user's choice.
            /// <summary>
            /// Given a list of answers, prompts the user to enter a number corresponding to one of the answers. 
            /// If the user enters a number that is not within the specified range,
            ///  the user is asked to enter another value.
            /// </summary>
            ///<param name="answers">The answer that is being validated in the method</param>
            /// <returns>It returns the user's choice or an invalid command message</returns>
        public static int GetValidAnswer(List<string> answers)
        { 
            
            // Feedback(jcollard 2022-02-09): Do this method first.
            
            // Here is an example of reading input:
            // https://jcollard.github.io/IntroToCSharpSite/examples/read-input
            
            // In your situation, you want to ensure that the users input is
            // between 1 and answers.Count

            // Note: This method shoudl simply ask the user to enter a value but
            // doesn't display the actual options. You will do that in AskQuestion.
            int userChoice;

            do
            {
                Console.Write("Enter a number that is between 0 and 5:");
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);
                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a number from 0 to 5");
                }
                else if (userChoice < 0)
                {
                    Console.WriteLine("That number is not greater than 0");
                }
                else if (userChoice > answers.Count)
                {
                    Console.WriteLine("That number is not less than 5");
                }

            } while (userChoice < 0 || userChoice > answers.Count);
            return userChoice;
        }

            //Initialize highest to 0 which shows the highest score we have gotten.
            //Initialize highestIx to 0 which shows the highest score we have gotten.
            //Loop through each score in scores, tracking the index in a variable currentIx
            //If the score is greater than the highest score then update the highest to store the new score
            //Update highestIx to store the currentIx 
            //After we have checked each score, highestIx should be the index of the highest score.
            //return results[highestIx]
            /// <summary>
            /// Given two lists, one representing the scores for each possible 
            /// result and one representing each possible result, 
            /// determines which score is the highest and returns the corresponding string from the results list.
            /// </summary>
            /// <param name="scores"> The amount of points for each result</param>
            /// <param name="results">A list of results the player could get</param>
            /// <returns>It returns the corresponding string from the results list</returns>
        public static string GetResult(List<int> scores, List<string> results)
        {
            // TODO(jcollard 2022-02-11):
            // Complete this method last. I've created an example
            // showing how you can use two lists that are associated to
            // find the shortest person in a list.
            //
            // Tips:
            // * In the example, they use a list of doubles. Your scores are int values.
            // * You are looking for the highest score rather than the lowest height. 
            // * The names of your lists are scores (rather than heights) and results (rather than names).
            //
            // Start by copying everything inside of the method here first.
            // Then modify it to meet your needs:
            // https://jcollard.github.io/IntroToCSharpSite/examples/association-list
           
            return null;
        }
        
    }

    class Question
    {
        // Feedback(jcollard 2022-01-28): I modified this class by making the
        // fields public and changing the parameter names to lower case. There
        // was an error stating that the variable name Question had to be
        // different than the class name Question.
        //
        // Note: Marking the field as public allows it to be used in your
        // Program class.
        public string question; 

        // Feedback(jcollard 2022-01-28): This constructs a new list so we
        // can add answers to it.
        public List<string> answers = new List<string>();

    }
}
