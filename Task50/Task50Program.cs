// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


bool Checkcondition(int[,] array)
{   
    int x = EnterData("Введите координату по строке: ");
    int y = EnterData("Введите координату по столбцу: ");
    bool response = false;
    if(x <= array.GetLength(0) &&  y <= array.GetLength(1))
    {
        response = true;
        Console.WriteLine(array[x,y]);
    }
    else 
    {
        response = false;
        Console.WriteLine("Элемента с такими координатами нет в массиве");
    }
    return response;
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


//Запрос количества строк

int rows = EnterData("Введение количество строк");

//Запрос количества столбцов

int columns = EnterData("Введение количество столбцов");
// Создание двухмерного  массива, заполненного случайными числами
int[,] matrix = FillArray(rows, columns, 0, 10);
//Выведение массива на экран
PrintArray(matrix);
// Запросить координаты элемента массива


//Проверка условия и вывод результата
Checkcondition(matrix);