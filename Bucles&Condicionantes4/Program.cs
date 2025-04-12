using static System.Console;

string option;

do
{
    
    WriteLine("Option A");
    WriteLine("Option B");
    WriteLine("Option C");
    WriteLine("Option E to exit");
    WriteLine("Select an option: ");
    option = ReadLine()!;
    Clear();

    switch(option)
    {
        case "A":
            WriteLine("You chose option A");
        break;

        case "B":
        WriteLine("You chose option B");
        break;

        case "C":
        WriteLine("You chose option C");
        break;

        default:
            WriteLine("That option does not exist, try a valid option");
        break;
    }
} while (option != "E");

WriteLine("Byeee");

int counter = 0;

do
{
    WriteLine(counter);
    counter ++;
} while (counter != 10);