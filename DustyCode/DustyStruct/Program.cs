using static Dusty.ConsoleWriter;
using static System.Console;

//Struct 
MyStruct thestruct = new MyStruct(23,49);
//Record
TheRecord myrecord = new TheRecord { Message = "My Record Message"};

//Better Record 
BetterRecord betterRecord = new BetterRecord { Message = "I'm a new Message", RealValue =45.5 };
Clear();
WriteLine("Dusty Struct Program");
WriteLine("Stuct Information");
WriteLine($"X = {thestruct.X}");
WriteLine($"Y = {thestruct.Y}");
WriteLine("Record Information");
WriteLine($"The Message is: {myrecord.Message}");
WriteLine("Better Record");
WriteLine($"Message = {betterRecord.Message}\nReal Number = {betterRecord.RealValue}");
ReadLine();