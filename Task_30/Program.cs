// Покажите кубы чисел, заканчивающихся на чётную цифру.

int n = 10;
int x = 2;
int i = 2;

while (x <= n)
{
    if (x % 2 == 0)
    {
        Console.Write(x + "\t");
    }
    x = x + 2;
}
Console.WriteLine();

while (i <= n)
{
    int i1 = i * i * i;
    Console.Write(i1 + "\t");
    i++;
}
