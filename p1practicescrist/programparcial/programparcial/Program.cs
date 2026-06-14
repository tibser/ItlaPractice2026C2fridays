Console.WriteLine("Welcome!");

string option;

do
{
	Console.WriteLine("\n1. Calculator");
	Console.WriteLine("2. Student Evaluation");
	Console.WriteLine("3. Exit");

	option = Console.ReadLine();

	if (option == "1")
	{
		decimal firstNumberInput;
		decimal secondNumberInput;
		decimal total = 0;
		int operationInput;

		Console.WriteLine("Enter the first number:");
		decimal.TryParse(Console.ReadLine(), out firstNumberInput);

		Console.WriteLine("Enter the second number:");
		decimal.TryParse(Console.ReadLine(), out secondNumberInput);

		Console.WriteLine("1.Add 2.Subtract 3.Multiply 4.Divide");
		int.TryParse(Console.ReadLine(), out operationInput);

		switch (operationInput)
		{
			case 1:
				total = firstNumberInput + secondNumberInput;
				break;

			case 2:
				total = firstNumberInput - secondNumberInput;
				break;

			case 3:
				total = firstNumberInput * secondNumberInput;
				break;

			case 4:

				if (secondNumberInput == 0)
				{
					Console.WriteLine("Cannot divide by zero.");
					break;
				}

				total = firstNumberInput / secondNumberInput;
				break;

			default:
				Console.WriteLine("Invalid operation.");
				continue;
		}

		Console.WriteLine($"Result: {total}");
	}
	else if (option == "2")
	{
		decimal grade1;
		decimal grade2;
		decimal grade3;

		Console.WriteLine("Enter grade 1:");
		decimal.TryParse(Console.ReadLine(), out grade1);

		Console.WriteLine("Enter grade 2:");
		decimal.TryParse(Console.ReadLine(), out grade2);

		Console.WriteLine("Enter grade 3:");
		decimal.TryParse(Console.ReadLine(), out grade3);

		decimal average = (grade1 + grade2 + grade3) / 3;

		Console.WriteLine($"Average: {average}");

		if (average >= 70)
		{
			Console.WriteLine("APPROVED");
		}
		else
		{
			Console.WriteLine("FAILED");
		}
	}
	else if (option == "3")
	{
		Console.WriteLine("Goodbye!");
	}
	else
	{
		Console.WriteLine("Invalid option.");
	}

} while (option != "3");