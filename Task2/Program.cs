// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    int size = new Random().Next(2, 10);
    int[] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(1, 1000);
    }

    return myArray;
}

int SumOddArrayElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    {
        sum += array[i];
    }

    return sum;
}

int[] newArray = CreateArray();
Console.WriteLine($"Массив: [{String.Join(";", newArray)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива = {SumOddArrayElements(newArray)}");
