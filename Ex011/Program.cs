//Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.










int y = 8;
int x = 8;
int sum = 0;
int[,] intArray = new int [x, y];
FillArray();
printArray();
Console.WriteLine();
ChengeArray();

void FillArray ()
{
    
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            intArray[i,j] = new Random().Next(1, 10);
                       
        }
  
        
    }
    
}

void ChengeArray ()
{
    
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {   
            
            if (i == j)
            {
                sum += intArray[i,j];
            }
            
            
        }
        
    }
    Console.WriteLine($" Суумма элементов диогонали = {sum}");
}
void printArray ()
{
    
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            
            Console.Write(intArray[i,j]+", ");
            
        }
        Console.WriteLine();
        
    }
}
