using static System.Console;
using static Dusty.ConsoleWriter;

void Start() 
{
    WriteLine("Dusty Person Console!!!");

    Person person = new Person{FirstName = "Frank"};
    WriteLine($"FistName: {person.FirstName}\nLastName: {person.LastName}\nGender: {person.GenderString}");
    Person person2 = new Person{  FirstName= "Janet", Gender = Gender.Fematle};
    WriteLine($"FirstName: {person2.FirstName}\nLastName: {person.LastName}\nGender: {person2.GenderString} ");


    ReadLine();
}


Start();
