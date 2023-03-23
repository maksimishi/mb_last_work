// Задаем исходный массив строк
string[] initialArray = new string[] { "abc", "de", "fghij", "kl", "mnop", "qr", "stuvwx", "y", "z" };

// Вызываем функцию, которая фильтрует массив
string[] filteredArray = FilterArray(initialArray);

// Выводим отфильтрованный массив на экран
Console.WriteLine("Отфильтрованный массив:");
foreach (string item in filteredArray)
{
    Console.WriteLine(item);
}


static string[] FilterArray(string[] inputArray)
{
    int filteredArraySize = 0;

    // Считаем количество элементов, которые будут в результирующем массиве
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            filteredArraySize++;
        }
    }

    string[] filteredArray = new string[filteredArraySize];
    int index = 0;

    // Проходимся по каждому элементу массива и проверяем его длину
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            // Если длина строки меньше или равна 3, добавляем ее в массив
            filteredArray[index++] = inputArray[i];
        }
    }

    // Возвращаем отфильтрованный массив
    return filteredArray;
}