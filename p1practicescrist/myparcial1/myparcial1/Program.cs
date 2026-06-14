using System.Numerics;

decimal firstNumberInput;
decimal secondNumberInput;
decimal total =0;
int operationInput;



Console.WriteLine("welcome to my calculator program");

Console.WriteLine("Please enter the first number:");
//var firstNumberInput = decimal.Parse (Console.ReadLine());
decimal.TryParse(Console.ReadLine(), out firstNumberInput);
Console.WriteLine("Please enter the second number:");
//var secondNumberInput = Convert.ToDecimal(Console.ReadLine());
decimal.TryParse(Console.ReadLine(), out secondNumberInput);

Console.WriteLine("Please enter the operation you want to perform:");
Console.WriteLine("1. Add, 2. Sustract, 3. Multiplication 4. Division 5. Exit:");

//var operationInput = Console.ReadLine();


//decimal firstNumberConverted = decimal.Parse(firstNumberInput);
//decimal secondNumberConverted = decimal.Parse(secondNumberInput);

//decimal total = firstNumberConverted + secondNumberConverted;

//logic operators

if(operationInput == 1)
{
	total = firstNumberInput + secondNumberInput;

}

if(operationInput == 2)
{

    total = firstNumberInput - secondNumberInput;

}


if (operationInput == 3)
{

	total = firstNumberInput * secondNumberInput;

}


if (operationInput == 4)
{

	total = firstNumberInput / secondNumberInput;

}


if (operationInput == 5)
{

	Console.WriteLine("Exiting the program. goodbye");
	return;

}




decimal total = firstNumberInput + secondNumberInput

Console.WriteLine($"The result of the operation is: {total}");

Console.ReadKey();