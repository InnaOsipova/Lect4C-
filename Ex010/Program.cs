//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба 
//индекса чётные, и замените эти элементы на их квадраты.

int [,] FillArray (int m, int n)
{
    int [,] newarray = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newarray[i,j] = new Random().Next(1, 10);
                       
        }
        
        
    }
    return newarray;
}


void ChengeArray (int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i % 2) == 0 && (j % 2) == 0)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
            Console.Write(arr[i,j]+", ");
            
        }
        Console.WriteLine();
    }
}

void printArray (int[,] getArray)
{
    
    for (int i = 0; i < getArray.GetLength(0); i++)
    {
        for (int j = 0; j < getArray.GetLength(1); j++)
        {
            
            Console.Write(getArray[i,j]+", ");
            
        }
        Console.WriteLine();
        
    }
}

int v = 6;
int k = 5;
int[,] intArray = FillArray(v,k);
printArray(intArray);
Console.WriteLine();
ChengeArray(intArray);