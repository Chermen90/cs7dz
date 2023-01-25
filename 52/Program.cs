using static System.Console;
Write("Введите размер матрицы и диапазон через пробел: ");
string[] parameteress = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameteress[0]), int.Parse(parameteress[1]), int.Parse(parameteress[2]), int.Parse(parameteress[3]));

PrintMatrixArray(array);

//объявляем и печатаем переменную куда помещаем результат метода по нахождению среднеарифм-го
string res = EvNum(array);
WriteLine();
WriteLine(res);

//метод для создания массива
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

//метод для печати массива
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

//метод по нахождению среднеарифм-го в столбце
 string EvNum(int[,] sumArr)
 {
    float result = 0;
    string finalRes = string.Empty;
    //делаем перевёрнутый цикл
    for(int j = 0; j < sumArr.GetLength(1); j++)
    {
        for(int i = 0; i < sumArr.GetLength(0); i++)
        {
            //находим сумму чисел каждого столбцв
            result += sumArr[i, j];
        }
        //печатаем рез-т чтобы видеть, что суммируем правильно
        WriteLine($"current res = {result}");
        //делим полученную сумму на кол-во строк в массиве
        result = result/ sumArr.GetLength(0);
        //помещаем среднеариф-е в строку
        finalRes += "  " + result.ToString("0.0");
        //обнуляем переменную резалт и цикл идёт по массиву снова
        result = 0;
    }
    return finalRes;
 }