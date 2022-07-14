// F(1) = 1
// f(2) =1
// f(n) = f(n-1)+f(n-2);

double Fibonnachi (int n)
{
    if (n == 1 || n == 2) return 1;
    else return (Fibonnachi(n - 1) + Fibonnachi (n - 2));
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonnachi(i));
}