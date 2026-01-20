// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What would you like to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string operandType = Console.ReadLine().ToUpper();

if (operandType == "A")
{
    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
}
else if (operandType == "S")
{
    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
}
else if (operandType == "M")
{
    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
}

Console.WriteLine("Press any key to close...");
Console.ReadKey();


