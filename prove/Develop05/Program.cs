class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goal");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Which type of goal would you like to create?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Choose a goal type: ");
                    int goalType = Convert.ToInt32(Console.ReadLine());
                    manager.CreateNewGoal(goalType);
                    break;
                case 2:
                    manager.ListGoals();
                    break;
                // Implement cases 3, 4, 5 for Save, Load, Record goals
                // case 3:

                // case 4:

                // case 5:

                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}