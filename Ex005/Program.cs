//Задача 45: Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.

int[] CopyArray (int[] oldarray)
{
    int[] newArray = new int [oldarray.Length];
    for (int i = 0; i < oldarray.Length; i++)
    {
        newArray[i] = oldarray[i];
    }
    return newArray;
}

int [] array = new int [] {1, 3, 3, 5, 7, 20, 3, 56};
Console.WriteLine(String.Join(" | ", CopyArray( array)));