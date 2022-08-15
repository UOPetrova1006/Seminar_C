while (true)
{
    Console.WriteLine("Введите оператор +/-/*/: или end для выхода");
    string Operator = Console.ReadLine();
     if (Operator == "end")
     {
        break;
     }
    Console.WriteLine("Введите 1 число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    
    if (Operator == "+")
    {
        Console.WriteLine(number1 + number2);
    }
    else if (Operator == "-")
    {
        Console.WriteLine(number1 - number2);
    }
    else if (Operator == "*")
    {
        Console.WriteLine(number1 * number2);
    }
    else if (Operator == ":")
    {
        Console.WriteLine(number1 / number2);
    }
}


