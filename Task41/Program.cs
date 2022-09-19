


    int m;
    Console.WriteLine("Введите число элементов массива");
    m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];
    int i;
    for (i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

Console.WriteLine($"В заданном массиве {PozitiveElement(array)} чисел больше 0");

double PozitiveElement(int[] array)
{
    int result = 0;
    int j;
    for(j = 0; j < m; j++)
    {
        if(array[j] > 0)
        {
            result++;
        }
    }
    return result;
}