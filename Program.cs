using System;
using System.Collections.Generic;

namespace DanielPersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            static int AskQuestion(Question)
            {
                //Display the question to the user
                //Loop through each answer and display it
                //Using the GetValidAnswer method get and return the users response
                /// <summary>
                /// This displays the question and all of the answers and prompts the user to choose one the answers and returns the answer.
                /// </summary>
                return -1;
            }
            static int GetValidAnswer(List<string> answers)
            {
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
                return -1;
            }
            static string GetResult(List<int> scores, List<string> results)
            {
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
                return null;
            }
        }
    }

    class Question
    {
        string Question;
        List<string> Answers;
    }
}
