# Описание алгоритма решения задачи
## Структура программы
1. Метод ввода данных
2. Метод формирования нового массива
3. Метод вывода данный

### Метод ввода данных (ReadData)
В данном методе считывается введенная строка из консоли и затем перобразуется в массив строк при помощи метода .Split().
>string[] stringArray = inputLine.Split(',', StringSplitOptions.TrimEntries);

В данном методе используется свойство "StringSplitOptions.TrimEntries" для удаления пробелов.

### Метод формирования нового массива (StringSelector)
В данный метод передается массив строк, полученный из метода "ReadData". После этого необходимо создать новый массив строк для последующего заполнения, однако, на данном этапе мы не знаем сколько памяти необходимо выделить. Поэтому необходимо ввести счетчик и, используя, цикл подсчитать кол-во подходящих нам строк.

    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            count++;
        }
    }
После этого пишем еще один цикл и заполняем новый массив подходящими строками.

### Метод вывода данных (PrintData)
Данный метод предназачен для корректного отображения массива в консоли. С помощью цикла выводим данные в консоль.