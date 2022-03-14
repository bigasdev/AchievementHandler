using System;

namespace achievementsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while(!done){
                var achievement = new AchievementHandler();
                // Display title as the C# console calculator app.
                Console.WriteLine("\n");
                Console.WriteLine("Achievement handler and daily tracker\r");
                Console.WriteLine("------------------------\n");

                // Ask the user to type the first number.
                Console.WriteLine("What you want to do?\n");

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Check your achievements");
                Console.WriteLine("\tb - Add a new achievement");
                Console.WriteLine("\tc - Mark an achievement as complete");
                Console.WriteLine("\td - Close the program");
                Console.WriteLine("Your option? \n");

                // Use a switch statement to do the math.
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine("\n");
                        Console.WriteLine(achievement.ReadAchievements());
                        Console.WriteLine("\n");
                        Console.WriteLine("Press any button to continue...\n");
                        Console.ReadKey();
                        break;
                    case "b":
                        Console.WriteLine("\n");
                        Console.WriteLine($"What is the name of your achievement?");
                        var name = Console.ReadLine();
                        Console.WriteLine("\n");
                        Console.WriteLine("What is the achievement?");
                        var text = Console.ReadLine();
                        achievement.CreateAchievement(name, text);
                        Console.WriteLine("\n");
                        Console.WriteLine("Press any button to continue...\n");
                        Console.ReadKey();
                        break;
                    case "c":
                        Console.WriteLine($"Which assignment?");
                        var achievementName = Console.ReadLine();
                        achievement.MarkAsCompleted(achievementName);
                        Console.WriteLine($"{achievementName} Marked as completed!\n");
                        Console.WriteLine("\n");
                        Console.WriteLine("Press any button to continue...\n");
                        break;
                    case "d":
                        done = true;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
