// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

void Mass (int[] array)
{
    int index = 0;

    while (index < array.Length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] mass)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(mass[i] + "\t");
    }
}

int[] array = new int [8];

Mass(array);
PrintArray(array);