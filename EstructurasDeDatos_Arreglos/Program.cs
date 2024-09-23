using static System.Console;

int[] array = [7, 2, 56, 4, 1215, 6];

int sumOfArray = array[0] + array[1] + array[2] + array[3] + array[4] + array[5];

if(sumOfArray is 21)
{
    WriteLine($" The sum of each element of the array is: {sumOfArray}");
}
else if(sumOfArray is not 21)
{
    WriteLine("The sum of each element of the array is not: 21");
    WriteLine($"is: {sumOfArray}");
}