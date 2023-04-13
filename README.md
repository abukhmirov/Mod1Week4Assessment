# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

## Setup

Fork this repository!

## Questions (12 Points Possible)
Edit this `README.md` file - answer the BLANK questions before moving on to the exercise.  Make sure to SAVE your changes to the README before moving on!

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  
    
  AB:  C is not valid, because the variable isn't assigned the class Chair. The class needs to be specified in either way from A, B, and C.
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:
AB: OOP is a type of programming languages that is created with objects to organize data. It uses Inheritance, Encapsulation, Abstraction and Polymorphism to organized and relate code. OOP languages have elements such as classes and objects.

3. What is Automated Testing?
Automated testing is a debugging method that is easier and faster then manual testing. It uses a XUnit project to "run" a referenced copy of code to check the primary code. This makes it faster to debug by automating the running of code for the purpose of testing.

4. What are some benefits of creating tests for our projects?
We can spend less time testing code and more time actually making it. Testing also lets us see our code more closely and allows us to figure out specific bugs that need squishing.

5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?
We need to set a reference to the main project in the test project. In VS this can be done by right clicking the test project, clicking Add and clicking project reference. The last step is to choode which project you want to reference.

6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working.
Test 1: CreatedVariables_GetAssigned_CorrectValues, Test 2: Sumary_HasCorrectValues_FromProperties, Test 3: MilesDriven_IsAddedCorrectly, 
Test 4: Paint_IsChangedCorrectly


```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Sumary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```



## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When completed, commit the progress you have made, and push your project to GitHub.  Instructors will be following up with some video feedback!

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
