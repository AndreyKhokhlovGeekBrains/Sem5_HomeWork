// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    int size = new Random().Next(2, 10);
    int[] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }

    return myArray;
}

int CountEvenNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }

    return count;
}

int[] newArray = CreateArray();
Console.WriteLine($"Массив: [{String.Join(";", newArray)}]");
Console.WriteLine($"Количество чётных чисел в массиве = {CountEvenNums(newArray)}");
