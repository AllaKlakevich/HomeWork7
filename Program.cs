// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray(int rows, int cols, double min, double max){
//     double[,] array = new double[rows, cols];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = new Random().NextDouble()*(max-min)+min;
//     return array;
// }

// void Show2dArray(double[,] array){ 
//     for(int i=0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input num of rows "); 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of cols "); 
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of min "); 
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input num of max "); 
// double max = Convert.ToDouble(Console.ReadLine());

// double[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int [,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min,max+1);
    return array;
}

void Show2dArray(int[,] array){ 
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

// void FindElement(int[,] array, int m, int n){
//     if(m<array.GetLength(0) && n<array.GetLength(1))
//         Console.WriteLine("Искомый элемент " + array[m,n]);
//     else 
//         Console.WriteLine("Такого элемента в массиве нет");
// }

// Console.Write("Input num of rows "); 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of cols "); 
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of min "); 
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of max "); 
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();
// Console.Write("Введите позицию искомого элемента в строке ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию искомого элемента в столбце ");
// int n = Convert.ToInt32(Console.ReadLine());
// FindElement(array, m, n);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Avarage(int[,] array){
    for(int j = 0; j < array.GetLength(1); j++){
        double sum = 0;
            for(int i=0; i < array.GetLength(0); i++){
            sum = sum + array[i,j];
            }
        sum = sum/array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов {j} столбца равно {sum}");
    }
}

Console.Write("Input num of rows "); 
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num of cols "); 
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num of min "); 
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num of max "); 
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,cols,min,max);
Show2dArray(array);
Console.WriteLine();
Avarage(array);


