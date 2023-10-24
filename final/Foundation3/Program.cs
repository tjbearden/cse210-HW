using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("West Corniche Road", "EAl Ras Al Akhdar", "Abu Dhabi", "123", "United Arab Emirates");
        addresses[1] = new Address("Church of the Dirt", "Metroplitan City of Rome Capital", "Rome", "VfV5+86", "Italy");
        addresses[2] = new Address("Equestrian Park", "South Jordan", "Utah", "84009", "USA");

        Event[] events =  new Event[3];
        events[0] = new Lecture("How to Find a wife","Come learn how to find a wife at the Emirates Palace Mandarin Oriental in Abu Dhabi","01/01/2024","08:00-15:00",addresses[0],"Shaka Khan","25 People");
        events[1] = new Reception("Dave and Amandas Wedding","Come Celebrate with the happy couple","10/13/2023","15:00",addresses[1],"a&d@gmail.com");
        events[2] = new OutdoorGathering("BBQ Competition","$25, gets you in the door with a chance to sample some of the best BBQ this side of the Mississippi!","06/11/2024","06:00pm",addresses[2],"Sunny, with a chance of Meatballs");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Event N°: {i + 1}");
            Console.WriteLine("\n-STANDARD DETAILS-");
            Console.WriteLine(events[i].StandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(events[i].FullDetails());
            
        }
    }
}