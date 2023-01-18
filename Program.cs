// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Welcome to the second number finder!");
Console.WriteLine("Please, insert three-digit number:");
var input = Console.ReadLine();
var number = default(int);
if (!int.TryParse(input, out number))
{
    Console.WriteLine("Sorry, inserted value is not an integer... Bye!");
    return;
}

if ((number < 0 && input?.Length == 4) || (number > 0 && input?.Length == 3))
{
    Console.WriteLine($"{(number/10) % 10}".Last());
}
else
{
    Console.WriteLine("Sorry, inserted number is not three-digit... Bye!");
    return;
}