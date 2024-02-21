using System;

class Program
{
    static void Main(string[] args)
    {
        // Create events of each type
        LectureEvent lecture = new LectureEvent(
            "Lecture Title",
            "A fascinating talk about various topics.",
            new DateTime(2024, 3, 15, 14, 0, 0),
            "225 Main St, Allen Avenue, Ikeja, Lagos, Nigeria",
            "Promise Samuel",
            50
        );

        ReceptionEvent reception = new ReceptionEvent(
            "Reception Party",
            "Join us for a night of music and enjoyment!",
            new DateTime(2024, 4, 20, 18, 0, 0),
            "327 Oak St, Opebi, Ikeja, Nigeria",
            "everydayfun.com"
        );

        OutdoorEvent outdoor = new OutdoorEvent(
            "Enjoyment Galoooooorrrr in the Park",
            "Bring your family and friends for relaxation.",
            new DateTime(2024, 5, 25, 11, 0, 0),
            "911 Pine St, Alausa, Ikeja, Nigeria",
            "Sunny"
        );

        // Generate and display marketing messages for each event
        Console.WriteLine("Marketing Messages:\n");

        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}