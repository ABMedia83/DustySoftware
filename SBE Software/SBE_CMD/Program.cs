global using Dusty;
global using static Dusty.ConsoleWriter;
global using static System.Console;


//Start Method 
void Start()
{
    WriteTitle("This is some SBE Software");
    WriteLine("Here's what we think SBE means:");
    WriteLine("SHAME: sh");
    WriteLine("BLAME: bl");
    WriteLine("EXPLAIN: ex");
    Write("Pick your definiton: ");
    var choice = ReadLine();

    switch(choice)
    {
        case "sh": Shame(); break;
        case "bl": Blame(); break;
        case "ex": Explain(); break;
        default: WriteExit(Start); break;
    }
    
}

void Shame()
{
    WriteTitle("SHAME!!!!");
    WriteLine("We SHAME because we're HATERS!!!");
    WriteExit(Start,Shame);

}
void Blame() 
{
    WriteTitle("BLAME");
    WriteLine("We SHAME because are Content SUCKS!!!!");
    WriteExit(Start,Blame);

}
void Explain()
{
    WriteTitle("EXPLAIN");
    WriteLine("We don't EXPLAIN SH#T because we CAN'T!");
    WriteExit(Start,Explain);

}


Start();