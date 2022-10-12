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
// Выводим результат
void PrintData(string[] stringArray)
{
    Console.Write($"[<{stringArray[0]}>, ");
    for(int i =1; i < stringArray.Length - 1; i++)
    {
        Console.Write($"<{stringArray[i]}>, ");
    }
    Console.WriteLine($"<{stringArray[stringArray.Length - 1]}>]");
}

string[] stringArray = ReadData("Введите строки через запятую: ");
PrintData(stringArray);