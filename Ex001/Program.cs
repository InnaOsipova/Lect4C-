//Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)


int[] getArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

void reversArray(int[] intArray)
{
  for (int i = 0; i < intArray.Length / 2; i++)
  {
    int k = intArray[i];
    intArray[i] = intArray[intArray.Length - i - 1];
    intArray[intArray.Length - i - 1] = k;
  }
  Console.WriteLine(String.Join(" ", intArray));
}

int[] array = getArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
reversArray(array);
