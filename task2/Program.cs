// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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
int Sum(string array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += Convert.ToInt32(Convert.ToString(array[i]));
    }
    return sum;
}
void PrintArray(string array)
{
    int count = array.Length;
    System.Console.Write("Элементы массива: ");
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int A = IntupNumber("Введите число A: ");
string numberString = Convert.ToString(A);
int sum = Sum(numberString);
PrintArray(numberString);
System.Console.WriteLine($"Сумма элементов массива: {sum}");
