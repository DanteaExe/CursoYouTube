using System.Diagnostics;
using static System.Console;

WriteLine("Write a color: ");
string? color = ReadLine();

switch (color)
{
    case "Yellow":
        WriteLine("Bananas are yellow");
    break;

    case "Red":
    WriteLine("Red apples are red");
    break;

    case "Green":
        WriteLine("Watermelons are green");
    break;

    case "purple":
        WriteLine("Uvas are purple");
    break;
    
    default:
        WriteLine("something went wrong with that color");
    break;
}

WriteLine("Path A: ");
WriteLine("Path B: ");
WriteLine("Path C: ");

WriteLine("Write the path you want to follow: ");
string? path = ReadLine();

switch(path)
{
    case "A":
            WriteLine("this is path A");
            WriteLine("D");
            WriteLine("E");

            WriteLine("Write the path you want to follow: ");
            path = ReadLine();
            switch(path)
            {
                case "D":
                WriteLine("this is path D");
                break;

                case "E":
                WriteLine("this is path E");
                break;
            }
        break;

    case "B":
    WriteLine("this is path B");
        WriteLine("F");
        WriteLine("G");

        WriteLine("Write the path you want to follow: ");
        path = ReadLine();
        switch(path)
        {
            case "F":
            WriteLine("this is path F");
            break;

            case "G":
            WriteLine("this is path G");
            break;
        }
    break;

    case "C":
    WriteLine("this is path C");
    break;
}