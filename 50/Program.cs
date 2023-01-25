using static System.Console;
Write("Введите размер матрицы и диапазон через пробел: ");
string[] parameteress = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameteress[0]), int.Parse(parameteress[1]), int.Parse(parameteress[2]), int.Parse(parameteress[3]));

//принимаем от пользователя индексы строк и столбца
Write("Введите индекс строки и индекс столбца через пробел: ");
string[] parchecks = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintMatrixArray(array);

Write(' ');
//помещаем рез-т метода по поиску элемента в переменную и печатаем её
string final = CheckArr(array, int.Parse(parchecks[0]), int.Parse(parchecks[1]));
Write(final);

//метод создания массива
int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return resultArray;
 }

//метод печати массива
 void PrintMatrixArray(int[,] inArray)
 {
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 3} ");
        }
    WriteLine();
    }
 }

 // метод для поиска элемента в массиве
string CheckArr(int[,] arrSearch, int rowSearch, int colSearch)
{
    string result = string.Empty;
    for(int i = 0; i < arrSearch.GetLength(0); i++)
    {
        for(int j = 0; j < arrSearch.GetLength(1); j++)
        {
            //если введённые пользователем индексы есть в массиве, возвращаем значение по этим индексам, 
            if((i == rowSearch) && (j == colSearch))
            {
                return result = Convert.ToString(arrSearch[i, j]);
            }
            else
            {
                result = "Такого элемента в массиве нет";
            }
        }
    }
    return result;
}