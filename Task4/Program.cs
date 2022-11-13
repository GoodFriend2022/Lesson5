// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, 
// с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string message) // Запрашивает на ввод число
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int index, int length)
{
    if (length == 0) return;
    for (int i = 0; i < index; i++)
    {
        System.Console.Write(index + " ");
        length--;
        if (length == 0) return;
    }
    PrintNumbers(index + 1, length);
}

// void PrintNumbers(int length)
// {
//     int count = 0;
//     for (int i = 1; i <= length; i++)
//     {
//         for (int j = 1; j <= i; j++)
//         {
//             System.Console.Write(i + " ");
//             count++;
//             if (length <= count) return;
//         }
//     }
// }

int length = Prompt("Введите число");
PrintNumbers(1, length);

