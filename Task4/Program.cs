// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, 
// с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string message) // Запрашивает на ввод число
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)// Возвращает массив
{
    int length = array.Length;
    System.Console.Write(array[0]);
    for (int i = 1; i < length; i++)
    {
        System.Console.Write($"; {array[i]}");
    }
}

void PrintNumbers(int length, int count, int index)
{
    int value = length;
    if (index == 0) return;
    PrintNumbers(length, value, index - 1);
    for (int i = 0; i < index; i++)
    {
        count -= index- i;
        if (count == 0) return;
        System.Console.Write(index + " ");
        System.Console.Write($"({count})");
    }
}

// int[] CreateArray(int length, int count)
// {
//     int[] array = new int[length];
//     if (count == 1)
//     {
//         array[0] = count;
//         return array;
//     }
//     CreateArray(length, count - 1);
//     for (int i = 0; i < count; i++)
//     {
//         if (length/2 == count - 1 + i) return array;
//         array[count - 1 + i] = count;// 1 2 2 3        1 2 2 3 3 3 4 4
//     }
//     return array;
// }

int length = Prompt("Введите число");
// int[] numbers = CreateArray(length, length);
PrintNumbers(length, length, length);
System.Console.WriteLine();
// PrintArray(numbers);

