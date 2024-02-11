// Breathing Activity class
class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            DisplaySpinner(3); // Spinner for 3 seconds
            Console.WriteLine("Breathe out...");
            DisplaySpinner(3); // Spinner for 3 seconds
        }

        Console.WriteLine("\nGood job! You have completed the breathing activity for {0} seconds.\n", duration);
        Thread.Sleep(1000);
    }
}