using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Chipo Mugo", "Probability", "6.2", "1-5" );

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Chipo Mugo", "Physcical Geoghraphy", "Plate Techtonics" );

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}