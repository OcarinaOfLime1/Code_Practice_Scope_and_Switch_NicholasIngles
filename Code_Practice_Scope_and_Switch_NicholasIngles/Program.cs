// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.ComponentModel.Design;
int Correct = 0;
int Total = 0;

Menu:
Console.WriteLine("\n");
Console.WriteLine("1. Multiplication");
Console.WriteLine("2. Division");
Console.WriteLine("3. Exit");
Console.Write("Make a selection: ");
string UserInput1 = Console.ReadLine();

switch (UserInput1)
{
    case "1":
        Random Multiplication = new Random();
        int num1 = Multiplication.Next(2, 6);
        int num2 = Multiplication.Next(2, 16);
        int num3 = Multiplication.Next(2, 11);
        int answer1 = num1 * num2 * num3;

        Multiplication:
        try
        {
            Console.WriteLine("\nA bricklayer stacks bricks in " + num1 + " rows, with " + num2 + " bricks in each row. On top of each row, there is a stack of " + num3 + " bricks. How many bricks are there in total?");
            Console.Write("Your answer: ");
            int UserInput2 = int.Parse(Console.ReadLine());

            if (UserInput2 == answer1)
            {
                Console.WriteLine("\nCorrect");
            }
            else
            {
                Console.WriteLine("\nIncorrect");
                Console.WriteLine("Answer: " + answer1);
            }
        }
        catch
        {
            Console.WriteLine("\nInvalid input, try again");
            goto Multiplication;
        }
        break;
    case "2":
        Random Division = new Random();
        int num4 = Division.Next(2, 16);
        int num5 = num4 * Division.Next(2, 21);
        int answer2 = num5 / num4;

        Division:
        try
        {
            Console.WriteLine("If you have " + num5 + " tickets for the fair and each ride costs " + num4 + " tickets, how many rides can you go on?");
            Console.Write("Your answer: ");
            int UserInput3 = int.Parse(Console.ReadLine());

            if (UserInput3 == answer2)
            {
                Console.WriteLine("\nCorrect");
            }
            else
            {
                Console.WriteLine("\nIncorrect");
                Console.WriteLine("Answer: " + answer2);
            }
        }
        catch
        {
            Console.WriteLine("\nInvalid input, try again");
            goto Division;
        }
        break;

    case "3":
        goto Exit;

        break;

    default:
        Console.WriteLine("\nInvalid input");
        break;
}
goto Menu;

Exit:
double Percent = (Correct / Total) * 100;
Console.WriteLine("\nCongrats, you got " + Correct + " questions correct.");
Console.WriteLine(Percent + "% success rate.");