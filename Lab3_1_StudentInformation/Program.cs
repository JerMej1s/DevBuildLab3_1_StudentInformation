using System;

namespace Lab3_1_StudentInformation
{
    class Program
    {
        static bool KeepGoing()
        {
            bool done = false;
            bool result = false;

            while (!done)
            {
                Console.Write("\nDo you want to learn more about another student? (y/n): ");

                string userContinue = Console.ReadLine().ToLower();

                if (userContinue == "y" || userContinue == "yes")
                {
                    result = true;
                    done = true;
                }
                else if (userContinue == "n" || userContinue == "no")
                {
                    result = false;
                    done = true;
                }
                else
                {
                    Console.WriteLine("Please type \"y\" or \"n\"");
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3.1 Student Information\n");

            string[] studentNames = { "Jane Doe", "John Roe", "Zane Poe" };
            string[] studentFavFood = { "avocados", "blueberries", "cantelopes" };
            string[] studentPreviousTitle = { "President", "Vice President", "Secretary" };
            bool isValidInput = false;

            Console.WriteLine("Welcome to our DevBuild class!");

            do
            {
                do
                {
                    Console.Write($"\nWhich student would you like to learn more about? (enter a number 1-{studentNames.Length}): ");
                    string userInputStudentChoice = Console.ReadLine();
                    bool isInt = int.TryParse(userInputStudentChoice, out int userStudentChoice);
                    userStudentChoice += 1;

                    if (!isInt || userStudentChoice < 1 || userStudentChoice > studentNames.Length)
                    {
                        isValidInput = false;
                        Console.WriteLine("\nThat is not a valid input. Let's start over.");
                        continue;
                    }
                    else
                    {
                        isValidInput = true;

                        Console.WriteLine($"\nStudent {userStudentChoice} is {studentNames[userStudentChoice]}. What would you like to know about {studentNames[userStudentChoice]}?\n");
                        Console.Write("(Enter 1 for favorite food or 2 for previous title): ");
                        string userInputGetInfoChoice = Console.ReadLine();
                        bool isValidChoice = int.TryParse(userInputGetInfoChoice, out int userGetInfoChoice);

                        if (userGetInfoChoice == 1)
                        {
                            isValidInput = true;
                            Console.WriteLine($"\n{studentNames[userStudentChoice]}'s favorite food is {studentFavFood[userStudentChoice]}.");
                        }
                        else if (userGetInfoChoice == 2)
                        {
                            isValidInput = true;
                            Console.WriteLine($"\n{studentNames[userStudentChoice]}'s previous title is {studentPreviousTitle[userStudentChoice]}.");
                        }
                        else
                        {
                            isValidInput = false;
                            Console.WriteLine("\nThat is not a valid input. Let's start over.");
                            continue;
                        }
                    }
                }
                while (!isValidInput);
            }
            while (KeepGoing());
        }
    }
}
