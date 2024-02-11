using System;
using System.Threading;

// Base class for activity
abstract class Activity
{
    protected int duration; // Duration of activity in seconds

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public abstract void PerformActivity();

    //Display a spinner during pauses
    protected void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}