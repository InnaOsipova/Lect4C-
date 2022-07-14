//Задача 42: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.


void GetResult (int number)
{
    string result= "";
    while (number > 0)
    {
        result = number%2 + result;
        number /= 2;

    }
    Console.WriteLine(result); 
}

GetResult(2);
