// Напишите программу замена элементов массива: положительные элементы массива замените на отрицательные и наоборот


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

void ReleaseArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
   
    
}

Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");