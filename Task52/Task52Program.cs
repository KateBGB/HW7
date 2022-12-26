// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void FindColAverage(int[,] matrix, int rows, int columns)
{   
    for(int i = 0; i< columns; i++)
    {
        double sum = 0;
        for(int j =0; j < rows; j++)
        {
            sum = sum + matrix[j,i];
        }
        double average = sum / rows;
        
        
        Console.Write($"{average}. ");
    }
   
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int start, int end)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Получить данные по размеру массива
int rows = EnterData("Введение количество строк");
int columns = EnterData("Введение количество столбцов");

//Задать двумерный массив
int[,] mymatrix = FillArray(rows, columns, 0, 20 );

PrintArray(mymatrix);

//Найти среднее арифметическое
FindColAverage(mymatrix, rows, columns);
