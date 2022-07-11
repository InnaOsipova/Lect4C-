//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

bool isTriangl (int a, int b, int c)
{
    if (a+b > c) 
    {
        if (b+c > a)
        {
            if (c+a > b)
            return true;
        }
    }
    return false;
}

Console.WriteLine(isTriangl(12, 8, 7));
