using System;

class Program
{
    static void Main(string[] args)
    {
                while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter duration in seconds: ");
                    int duration1 = Convert.ToInt32(Console.ReadLine());
                    BreathingActivity breathingActivity = new BreathingActivity(duration1);
                    breathingActivity.PerformActivity();
                    break;

                case "2":
                    Console.Write("Enter duration in seconds: ");
                    int duration2 = Convert.ToInt32(Console.ReadLine());
                    ReflectionActivity reflectionActivity = new ReflectionActivity(duration2);
                    reflectionActivity.PerformActivity();
                    break;

                case "3":
                    Console.Write("Enter duration in seconds: ");
                    int duration3 = Convert.ToInt32(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity(duration3);
                    listingActivity.PerformActivity();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness App!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}