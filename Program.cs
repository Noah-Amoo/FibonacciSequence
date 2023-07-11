//			FIBONACCI SEQUENCE
//	The sequence assumes that the first number is 1. The logic behind the code is that
//	the first three numbers in the sequence are labelled Previous, Current and Next.
//	When the while loop executes, the previous number is first printed, the next is calculated
//	by adding the previous and current, then current is assigned to previous, next assigned to current.
var previous = 1;
var current = 1;
var next = 0;
var count = 0;

Console.Write("How long should the Fibonacci Sequence be? ");
var userInput = int.Parse(Console.ReadLine());

while (count < userInput)
{
    Console.Write($"{previous} ");

    next = previous + current;
    previous = current;
    current = next;
    count++;
}
Console.WriteLine();
Console.ReadLine();