using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("25 de Mayo", "Avellaneda", "buenos Aires", "Argentina");
        LectureEvent lectureEvent = new LectureEvent("Jorge Luis Borges", 500, "The path of life", "This event is an introduction to the new book of Jorge Luis Borges", "07/25/2024", "20:00", a1);
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.ShortDescription());

        Address a2 = new Address("3375 E", "South Jordan", "Utah", "USA");
        ReceptionEvent receptionEvent = new ReceptionEvent("borgesfacundo@gmail.com", "The night of lights", "In this event we will enjoy incredible lights", "04/05/2024", "22:00", a2);
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.ShortDescription());

        Address a3 = new Address("Catupiry", "Acaracuzinho", "Ceara", "Brazil");
        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent("The night will be clear and cold", "Night of Red", "In this event everyone needs to come with something red", "07/26/2024", "23:30", a3);
        Console.WriteLine(outdoorGatheringEvent.StandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.ShortDescription());

    }
}