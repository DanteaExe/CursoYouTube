using static System.Console;

//first example
int number = 0;

if (number > 0)
{
    WriteLine($"the number {number} is positive :D");
}
else if(number < 0)
{
    WriteLine($"the number {number} is negative :D");
}
else
{
    WriteLine($"the number is cero");
}

//second example
string? name;
string? password;

WriteLine("Write your name: ");
name = ReadLine();

WriteLine("Write your password: ");
password = ReadLine();

if(name == "Dante" && password == "hola123")
{
    WriteLine($"welcome {name}");
}
else
{
    WriteLine("you cannot pass >:v");
}

//third example
string? ingredient1;
string? ingredient2;
string? ingredient3;

WriteLine("Write the first ingredient you want: ");
ingredient1 = ReadLine();

WriteLine("Write the second ingredient you want: ");
ingredient2 = ReadLine();

WriteLine("Write the third ingredient you want: ");
ingredient3 = ReadLine();

if(ingredient1 == "apples" || ingredient2 == "chocolate" || ingredient3 == "bannanas")
{
    WriteLine("i am happy with my licuado");
}
else
{
    WriteLine("i do not like my licuado unu");
}