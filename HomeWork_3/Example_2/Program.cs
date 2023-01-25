// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int xa, ya, za, xb, yb, zb;

int input() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр");
    }
     return res;   
}

Console.Write("Введите координату Х точки А: ");
xa = input();

Console.Write("Введите координату Y точки А: ");
ya = input();

Console.Write("Введите координату Z точки А: ");
za = input();

Console.Write("Введите координату Х точки B: ");
xb = input();

Console.Write("Введите координату Y точки B: ");
yb = input();

Console.Write("Введите координату Z точки B: ");
zb = input();

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}

double result = Distance(xa, ya, za, xb, yb, zb);

Console.WriteLine($"Расстоняние между двумя точками: {result.ToString("0.##")}");