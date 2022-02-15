// Возведите число А в натуральную степень B, используя цикл.

Console.WriteLine("Введите число A ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральный показатель степени");
int b = int.Parse(Console.ReadLine());
int a1 = 1;
int i = 1;

if (b == 0)
{
    a = 1;
}

while (i <= b)
{
    a1 = a1 * a;
    i++;

}

Console.WriteLine("Результат равен " + a1);
