// Задайте массив из случайных чисел.Найдите количество элементов массива, значения которых лежат в отрезке [10,99]



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,200);
    }
}

int ReleaseArray(int[] array)
{
    int Kolvo = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=10&&array[i]<=99)
        {
            Kolvo++;
        }
    }
    return Kolvo;      
}


Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine(ReleaseArray(array));