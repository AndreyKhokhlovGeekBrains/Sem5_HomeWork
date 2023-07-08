// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами 
// массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray()
{
    int size = new Random().Next(2, 10);
    double[] myArray = new double[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Math.Round(new Random().NextDouble() * Math.Pow(10, new Random().Next(0, 4)), 4) * new Random().Next(-1, 2);

    }

    return myArray;
}

int FindMaxIndex(double[] array)
{
    int maxIndex = 0;
    double maxValue = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxValue) {maxIndex = i; maxValue = array[i];};
    }
    return maxIndex;
}

int FindMinIndex(double[] array)
{
    int minIndex = 0;
    double minValue = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue) {minIndex = i; minValue = array[i];};
    }
    return minIndex;
}

double[] newArray = CreateArray();
Console.WriteLine($"Массив: [{String.Join(";", newArray)}]");

double difference = newArray[FindMaxIndex(newArray)] - newArray[FindMinIndex(newArray)];

Console.WriteLine(
    $"Разница между максимальным и минимальным элементами массива: {difference}"
    );
