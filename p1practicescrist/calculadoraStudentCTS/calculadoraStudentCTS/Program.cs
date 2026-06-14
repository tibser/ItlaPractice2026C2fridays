Console.WriteLine("Academic Helper Program");

string option;

do
{
	Console.WriteLine("\n========================");
	Console.WriteLine("1. Math Center");
	Console.WriteLine("2. Check Student Status");
	Console.WriteLine("3. Exit");
	Console.WriteLine("========================");
	Console.Write("Select an option: ");

	option = Console.ReadLine();

	switch (option)
	{
		case "1":

			decimal num1;
			decimal num2;
			decimal result = 0;
			int operation;

			Console.Write("\nEnter the first number: ");
			if (!decimal.TryParse(Console.ReadLine(), out num1))
			{
				Console.WriteLine("Invalid number.");
				break;
			}

			Console.Write("Enter the second number: ");
			if (!decimal.TryParse(Console.ReadLine(), out num2))
			{
				Console.WriteLine("Invalid number.");
				break;
			}

			Console.WriteLine("\nChoose an operation");
			Console.WriteLine("1 = Addition");
			Console.WriteLine("2 = Subtraction");
			Console.WriteLine("3 = Multiplication");
			Console.WriteLine("4 = Division");

			if (!int.TryParse(Console.ReadLine(), out operation))
			{
				Console.WriteLine("Invalid option.");
				break;
			}

			switch (operation)
			{
				case 1:
					result = num1 + num2;
					Console.WriteLine($"Answer: {result}");
					break;

				case 2:
					result = num1 - num2;
					Console.WriteLine($"Answer: {result}");
					break;

				case 3:
					result = num1 * num2;
					Console.WriteLine($"Answer: {result}");
					break;

				case 4:

					if (num2 == 0)
					{
						Console.WriteLine("You cannot divide by zero.");
					}
					else
					{
						result = num1 / num2;
						Console.WriteLine($"Answer: {result}");
					}

					break;

				default:
					Console.WriteLine("Operation not available.");
					break;
			}

			break;

		case "2":

			decimal test1;
			decimal test2;
			decimal project;
			decimal finalGrade;

			Console.Write("\nEnter first test grade: ");
			if (!decimal.TryParse(Console.ReadLine(), out test1))
			{
				Console.WriteLine("Invalid grade.");
				break;
			}

			Console.Write("Enter second test grade: ");
			if (!decimal.TryParse(Console.ReadLine(), out test2))
			{
				Console.WriteLine("Invalid grade.");
				break;
			}

			Console.Write("Enter project grade: ");
			if (!decimal.TryParse(Console.ReadLine(), out project))
			{
				Console.WriteLine("Invalid grade.");
				break;
			}

			finalGrade = (test1 + test2 + project) / 3;

			Console.WriteLine($"\nFinal Average: {finalGrade:F2}");

			if (finalGrade >= 70)
			{
				Console.WriteLine("Congratulations! Student Approved.");
			}
			else
			{
				Console.WriteLine("Student Failed.");
			}

			break;

		case "3":
			Console.WriteLine("Program closed.");
			break;

		default:
			Console.WriteLine("Please choose a valid option.");
			break;
	}

} while (option != "3");
