
using Dusty;
using static Dusty.ConsoleWriter;
using static System.Console;

void Start()
{
    WriteTitle("Dusty Startup"); 
    WriteLine("Dusty Meothod = dm");
    WriteLine("Dusty Divestor Saying = dds");
    Write("Choose your program: ");
    var program = ReadLine();

    switch(program)
    {
        case "dm":
        DustyMethod();

        break;
        case "dds":
        DustyDivestorSayings();
        break;
        default:
        WriteExit(Start);
        break;
    }
}

void DustyMethod()
{
    WriteTitle("The Dusty Method");
    WriteLine("This Method is very dusty!");

    WriteExit(Start,DustyMethod); 
}

void DustyDivestorSayings()
{

    WriteTitle("Divestor Sayings");

    WriteLine("I love Zaddy");
     WriteLine("Black Men Don't Protect us");
      WriteLine("Black Men Kill us at a high rate.");
       WriteLine("Black Men are Domonated!!1");
        WriteLine("Abort Black Boys...");
        WriteExit(Start, DustyDivestorSayings);



}

Start();





