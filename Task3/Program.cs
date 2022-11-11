// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Prompt(string message) // Запрашивает на ввод число
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

double[] CreateArray(int length, int min, int max)// Создает массив вещественных чисел
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)// Возвращает массив
{
    int length = array.Length;
    System.Console.Write(Math.Round(array[0], 2));
    for (int i = 1; i < length; i++)
    {
        System.Console.Write($"; {array[i]:f2}");
    }
}

double Difference(double[] array)//Возвращает разность между макс и мин элементами массива
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        else
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
    }
    return Math.Round(max - min, 2);
}

int length = Prompt("Введите длину массива");
int min = 0;
int max = 100;
double[] numbers = CreateArray(length, min, max);
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна => {Difference(numbers)}");