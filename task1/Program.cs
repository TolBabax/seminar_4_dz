// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int IntupNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено не корректное число. Попробуйте еще раз.");
    }
    return number;
}

int Dig(int number1, int number2)
{
    int number;
    while (true)
    {          
        if (number2 > 0)
        {
            // number = (int)Math.Pow(number1, number2);
            number = 1;
            for(int i = 1; i <= number2; i++)
            {
                number = number * number1; 
            }
            break;
        }
        else
        {
            int B = IntupNumber("Число В должно быть положительным: ");
            number = (int)Math.Pow(number1, B);
            break;
        }
    }
    return number;
}

int A = IntupNumber("Введите число A: ");
int B = IntupNumber("Введите число B: ");

int dig = Dig(A, B);

System.Console.WriteLine($"Число A в степени B равно: {dig}");