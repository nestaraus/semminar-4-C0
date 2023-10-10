// Найдите произведение пар чисел в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследний и тд. 



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}

void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length/2 + array.Length%2; i++)
    {
        Console.Write($" {array[i]*array[array.Length-1-i]} ");
        // array[0]  array[array.Length-1-0]
        // array[1]  array[array.Length-1-1]
        // array[2]  array[array.Length-1-2]
    }
 
}


Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
ReleaseArray(array);