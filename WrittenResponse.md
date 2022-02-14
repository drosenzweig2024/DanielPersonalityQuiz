# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

**TODO: Complete this section**
To match people with football players that they share interests with.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

In my video my program is demonstrating that my program can display questions and accept answers. It also shows that it is able to display a result.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My user has to answer the questions with a number that he/she/they input and receive an output of the football player that answer associates with.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<Question> questions = new List<Question>();
questions.Add(foodQuestion);
questions.Add(sportQuestion);
questions.Add(colorQuestion);
questions.Add(shoeQuestion);
questions.Add(videogameQuestion);
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (Question question in questions)
            {
                int result;
                result = Program.AskQuestion(question) - 1;
                testScores[result] = testScores[result] + 1;
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "questions"

### 3b iv.

Describes what the data contained in the list represents in your program

The list of all the questions that are going to be presented to the user

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the program without using the list.**

It would make it very difficult because without a list I would have to write an if/else statement for each question and its answers. This makes it so that if I was to add more answers to my questions I wouldn't have to keep adding if/else statements because I could simply just put the answers in a list.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
 public static string GetResult(List<int> scores, List<string> results)
        {
            if (results == null || scores == null) throw new Exception("must be non-null.");
            if (results.Count == 0) throw new Exception("Cannot process an empty list");
            if (scores.Count != results.Count) throw new Exception("Results and scores were not the same length");

            int highestScore = scores[0];
            string highestResult = results[0];

            int index1 = 0;
            foreach (int score in scores)
            {
                if (score > highestScore)
                {
                    highestScore = scores[index1];
                    highestResult = results[index1];
                }
                index1 = index1 + 1;
            }

            return highestResult;
        }
    }

           
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 string finalResult = Program.GetResult(testScores, testResults);
            Console.WriteLine($"{finalResult}");
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given two lists, one representing the scores for each possible result and one representing each possible result, determines which score is the highest and returns the corresponding string from the results list.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**
1.Initialize highest to 0 which shows the highest score we have gotten.
2.Initialize highestIx to 0 which shows the highest score we have gotten.
3.Loop through each score in scores, tracking the index in a variable currentIx
4.If the score is greater than the highest score then update the highest to store the new score
5.Update highestIx to store the currentIx 
6.After we have checked each score, highestIx should be the index of the highest score.
7.return results

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

GetResult(0)

Second call:

GetResult(Hi)

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
**TODO: Complete this section**

Condition(s) tested by the second call:

**TODO: Complete this section**

### 3d iii.

Result of the first call:

**TODO: Complete this section**

Result of the second call:

**TODO: Complete this section**