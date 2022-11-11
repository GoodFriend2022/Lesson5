// Задача 1: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message) // Запрашивает на ввод число
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length, int min, int max)// Создает массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)// Возвращает массив
{
    int length = array.Length;
    System.Console.Write(array[0]);
    for (int i = 1; i < length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
}

int FindEvenNumbers(int[] array)//Возвращает колличество четных чисел в массиве
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt("Введите длину массива");
int min = 100;
int max = 1000;
int[] numbers = CreateArray(length, min, max);
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве равно => {FindEvenNumbers(numbers)}");

