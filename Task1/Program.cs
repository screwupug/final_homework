//=====================================================================================
// Написать прграмму, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше или равна 3 символам.
//=====================================================================================

// Считываем данные и парсим строку в массив строк
string[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? " ";
    string[] stringArray = inputLine.Split(',', StringSplitOptions.TrimEntries);
    return stringArray;
}

string[] StringSelector(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newArray[j] = stringArray[i];
            j++;
        }
    }
    return newArray;
}

// Выводим результат
void PrintData(string[] stringArray)
{
    Console.Write($"[<{stringArray[0]}>, ");
    for (int i = 1; i < stringArray.Length - 1; i++)
    {
        Console.Write($"<{stringArray[i]}>, ");
    }
    Console.WriteLine($"<{stringArray[stringArray.Length - 1]}>]");
}


string[] stringArray = ReadData("Введите строки через запятую: ");
Console.WriteLine();
string[] newArray = StringSelector(stringArray);
Console.WriteLine("Исходный массив:");
PrintData(stringArray);
Console.WriteLine();
Console.WriteLine("Новый массив:");
PrintData(newArray);