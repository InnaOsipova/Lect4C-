//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int i = 0;
string fibo = ""+a+b;
while (i<N-2)
  {
   b=a+b;
   a=b-a;
   fibo=fibo+b;
   i=i+1;
  }
Console.WriteLine(fibo);
