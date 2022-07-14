//Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.

void FillArray (int m, int n)
{
    int [,] newarray = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newarray[i,j] = new Random().Next(1, 1000);
            Console.Write(newarray[i,j]+", ");
            
        }
        Console.WriteLine();
    }
}

FillArray(5,6);