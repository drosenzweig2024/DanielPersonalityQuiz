using System;
using System.Collections.Generic;

namespace DanielPersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
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

            
        } 
        
        public static void TestAll()
        {
            bool TestAskQuestion = testaskquestion.RunTest();
            Console.WriteLine($"test AskQuestion(filename): {testaskquestion}");
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
        public int AskQuestion(Question question) // I added the variable question here.
        {
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
        public int GetValidAnswer(List<string> answers)
        { 
            return -1;
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
        public string GetResult(List<int> scores, List<string> results)
        {
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
