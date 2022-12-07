string[] addArr()
{
    Console.Write($"Введите количество элементов в массиве: ");
    int arrNums = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[arrNums];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент под номером {i+1}: ");
        arr[i] = Console.ReadLine();
    }

    return arr;
}

void writeArr(string[] startArr1)
{
    Console.Write($"\n");
    Console.WriteLine($"Ваш массив: ");
    for (int i = 0; i < startArr1.Length; i++)
    {
        Console.Write($"\"{startArr1[i]}\"   ");
    }
}

void newArr(string[] startArr1)
{
    string[] someNewArr = new string[startArr1.Length];
    Console.Write($"\n");
    Console.WriteLine($"Массив, в котором остались только элементы с длиной не более 3 символов: ");
    for (int i = 0; i < startArr1.Length; i++)
    {
        if (startArr1[i].Length <= 3)
        {
            someNewArr[i] = startArr1[i];
            Console.Write($"\"{someNewArr[i]}\"   ");
        }
    }
}

string[] startArr = addArr();

writeArr(startArr);

newArr(startArr);