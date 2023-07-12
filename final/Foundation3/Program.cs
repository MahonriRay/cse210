using System;
List<Person> peeps = new List<Person>{
    new Person("Person 1", false),
    new Person("Person 2", true),
    new Person("Person 3", false),
    new Person("Person 4", true),
    new Person("Person 5", false),
    new Person("Person 6", false),
    new Person("Person 7", false),
    new Person("Person 8", true)
};

Lecture lect1 = new Lecture("Boring Lecture", "A boring lecture given by a boring person", "01/01/2024", 1200, new Address("P. Sherman 42 Wallaby Way", "Sydney", "New Wales", "Australia"), "Boring Speaker", 250);

Reception recept1 = new Reception("Reception for Receptionists, How to Recept",
    "The SuperBowl for Receptionists",
    "06/01/2023",
    1600,
    new Address("111 Totally Legit Street","Legit City", "Legit State", "United States"),
    peeps
);

OutdoorEvent eventOut = new OutdoorEvent("Outdoor Event", "This is an event taking place outdoors", "12/25/2099", 2300, new Address("Outdoor Place", "Outdoor City", "Outdoor State", "Outdoor Country"));
eventOut.GetWeather();

Console.Clear();

lect1.FullDetails();
lect1.ShortDescription();

recept1.FullDetails();
recept1.ShortDescription();
recept1.PrintGuestList();

eventOut.ShortDescription();
eventOut.FullDetails();