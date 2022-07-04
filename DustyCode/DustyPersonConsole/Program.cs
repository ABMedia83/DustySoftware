using static System.Console;
using static Dusty.ConsoleWriter;

void Start() 
{
    Clear();
    WriteLine("Select the Dusty Person you want to meat...");
    WriteLine("Natural BW = nbw");
    WriteLine("85 Stragg = stg");
    Write("Type it here: ");
    var meet = ReadLine();

    switch(meet)
    {
        default: 
        WriteExit(Start);
        break;
        case "nbw":
        SayingHelloToBW();

        break;
        case "stg":

        SayHellowTo85StragsBW();

        break;
    }




    ReadLine();
}

void SayingHelloToBW() 
{
    Clear();
    var woman = new BlackWoman(); 
    woman.FirstName = "Toya"; 
    woman.LastName = "Franklyn";
    woman.HasNaturalHair = true;
    WriteLine($"Say hello to {woman.FirstName}, here's what she has to say... ");
    WriteLine("I like my natural hair.");
    WriteLine("I hope you're having a good day."); 
    WriteLine("I can cook and clean for you.");
    WriteExit(Start,SayingHelloToBW);
    
}
void SayHellowTo85StragsBW() 
{
    Clear();
    var woman = new Black85Octain{ StraggComment = "I'm indapendent, now where is my snap benfits?"}; 
    woman.FirstName = "Kisha"; 
    woman.LastName = "Johnston";
    woman.HasNaturalHair = false;
  
    WriteLine($"Meet {woman.FirstName},here's what she thinks.");
    woman.StraggSaying();
    WriteLine(woman.StraggComment);
    WriteLine("Don't you like my pink Hair?");


    //Exit or stay in program 
    WriteExit(Start,SayHellowTo85StragsBW);
}


Start();
