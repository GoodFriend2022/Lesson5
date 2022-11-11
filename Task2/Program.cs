// Задача 2: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumUnevenIndex(int[] array)//Возвращает сумму элементов массива, стоящих на нечетных позициях
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int length = Prompt("Введите длину массива");
int min = -99;
int max = 100;
int[] numbers = CreateArray(length, min, max);
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна => {SumUnevenIndex(numbers)}");


