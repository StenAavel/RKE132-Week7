Console.WriteLine("Are you coming or leaving? (in/out):");
string UserChoice = Console.ReadLine();

if(UserChoice == "in")
{
    PrintHello();
} else
{
    PrintGoodbye();
}

PrintHello();
PrintGoodbye();


static void PrintHello() //function / method
{
    Console.WriteLine("Hello world!");
}

static void PrintGoodbye() 
{
    Console.WriteLine("See you later!");
}