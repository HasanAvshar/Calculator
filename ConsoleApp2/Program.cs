Calculation();
void Calculation()
{
    int select = 1;
    do
    {
        Console.Clear();
        switch (select)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] => Multiply");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[2] => Subtraction");
                Console.WriteLine("[3] => Multiplication");
                Console.WriteLine("[4] => Division");
                break;
            case 2:
                Console.WriteLine("[1] => Multiply");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[2] => Subtraction");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[3] => Multiplication");
                Console.WriteLine("[4] => Division");
                break;
            case 3:
                Console.WriteLine("[1] => Multiply");
                Console.WriteLine("[2] => Subtraction");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[3] => Multiplication");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[4] => Division");
                break;
            case 4:
                Console.WriteLine("[1] => Multiply");
                Console.WriteLine("[2] => Subtraction");
                Console.WriteLine("[3] => Multiplication");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[4] => Division");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }


        ConsoleKeyInfo info = Console.ReadKey(true);
        if (info.Key == ConsoleKey.UpArrow)
        {
            if (select == 1) select = 4;
            else select--;
        }
        else if (info.Key == ConsoleKey.DownArrow)
        {
            if (select == 4) select = 1;
            else select++;
        }
   
        if (info.Key == ConsoleKey.Enter)
        {
            Console.Clear();

            double number1;
            double number2;
            Console.Write("Enter number 1: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            switch (select)
            {
                case 1:
                    double result;
                    result = number1 + number2;
                    Console.WriteLine("Result: {0}", result);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Press enter and continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                   
                    break;
                case 2:
                    double result1;
                    result1 = number1 - number2;
                    Console.WriteLine("Result: {0}", result1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Press enter and continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    
                    break;
                case 3:
                    double result2;
                    result2 = number1 * number2;
                    Console.WriteLine("Result: {0}", result2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Press enter and continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
     
                    break;
                case 4:
                    double result3;
                    result3 = number1 / number2;
                    Console.WriteLine("Result: {0}", result3);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Press enter and continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    break;
            }
        }

    } while (true);
}