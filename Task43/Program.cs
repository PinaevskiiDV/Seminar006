Console.WriteLine("Введите b1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int d = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Точка пересечения заданных прямых расположена в координатах {(FindX(a, b, c, d), FindY(a, b, c, d))}");

float FindX(float a, float b, float c, float d)
{
    float x = -1 * (a - c) / (b - d);
    return x;
}

float FindY(float a, float b, float c, float d)
{
    float y = b * (-1 * (a - c) / (b - d)) + a;
    return y;
}