// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Размер массива");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string [N];

FillArray(array);
PrintArray(array);
Searching(array);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void Searching(string[] array)
{
    Console.WriteLine("массив строк длина которых меньше, либо равна 3 символам");
    for (int i = 0; i < array.Length; i++)
    {
        const int MaxLength = 3;
        if (array[i].Length <= MaxLength)
        Console.Write($"{array[i]} ");
    }
}
