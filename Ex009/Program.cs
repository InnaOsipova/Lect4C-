//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в 
//массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

void FillArray (int m, int n)
{
    int [,] newarray = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newarray[i,j] = i + j;
            Console.Write(newarray[i,j]+", ");
            
        }
        Console.WriteLine();
    }
}

FillArray(5,6);