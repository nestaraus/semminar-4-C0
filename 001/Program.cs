// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

void ReleaseArray(int[] array)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
    {
        SumPositive += array[i];
    }
    else
    {
        SumNegative += array[i];
    }
    }
    Console.WriteLine($"Сумма положительных = {SumPositive}, сумма отрицательных = {SumNegative}");
    
}

Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
ReleaseArray(array);
