using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("25 de Mayo","Avellaneda", "buenos Aires", "Argentina");
        LectureEvent lectureEvent = new LectureEvent("Jorge Luis Borges", 500, "The path of life", "This event is an introduction to the new book of Jorge Luis Borges", "07/25/2024", "20:00", a1);

        Console.WriteLine(lectureEvent.StandardDetails());

        Console.WriteLine(lectureEvent.GetFullDetails());

        Console.WriteLine(lectureEvent.ShortDescription());

    }
}