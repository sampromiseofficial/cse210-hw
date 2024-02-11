// Listing Activity class
class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        Console.WriteLine("You have {0} seconds to list items.\n", duration);
        Thread.Sleep(duration * 1000);

        Console.WriteLine("Enter the number of items you listed:");
        int itemCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nYou listed {0} items.\n", itemCount);
        Thread.Sleep(1000);
    }
}
