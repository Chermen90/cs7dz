using static System.Console;
Write("Введите размер матрицы через пробел: ");
string[] parameteress = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] intParams= Array.ConvertAll(parameteress, Convert.ToInt32);
double[,] array = GetArray(intParams[0], intParams[1]);
PrintArray(array);

double[,] GetArray(int row, int columns)
{
    double[,] resultArray = new double[row, columns];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            resultArray[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
        }
    }
    return resultArray;
}

void PrintArray(double[,] inArr)
{
    for(int i = 0; i < inArr.GetLength(0); i++)
    {
        for(int j = 0; j < inArr.GetLength(1); j++)
        {
            Write($"{inArr[i, j], 8} ");
        }
        WriteLine();
    }
}