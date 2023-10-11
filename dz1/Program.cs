// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
}

void ReleaseArray(int[] array)
{
    int Chetniy = 0;
    int Nechetniy = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]%2;
        if (array[i]==0)
    {
        Nechetniy++;
    }
    else
    {
        Chetniy++;
    }
    }
    Console.WriteLine($"Сумма четных = {Chetniy}, сумма нечетных = {Nechetniy}");
    
}

Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
ReleaseArray(array);
