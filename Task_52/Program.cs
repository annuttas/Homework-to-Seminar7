// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 0;
int n = 0;

Console.WriteLine("Введите количество строк массива:");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

double l = 0;

for(int j = 0; j < n; j++)
{
    l = 0;
    for (int i = 0; i < m; i++)
    {
        l = l + array[i,j];
        if (i==m-1)
        {   
            Console.Write($"{(l/m)} ");    
        }
    }
}
Console.WriteLine();