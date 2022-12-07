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

string[] arr1 = addArr();