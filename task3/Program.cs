// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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

int[] array = new int[8];

for (int i = 0; i <= 7; i++)
{
    int number = IntupNumber("Введите цифру массива: ");
    array[i] = number;
}


System.Console.WriteLine("[" + string.Join(", ", array) + "]");