// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int input() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр");
    }
     return res;   
}

double FuncDegree(int A, int B) {
    int res = 1;
    for (int i = 1; i <= Math.Abs(B); res *= A, i++){}
    return res;
}

Console.WriteLine("---------------------------------------------------- ");
Console.WriteLine("Программа, которая возводит число 'A' в степень 'B': ");
Console.WriteLine("---------------------------------------------------- ");

Console.Write("Введите число А: ");
int A = input();

Console.Write("Введите число B: ");
int B = input();

double result = FuncDegree(A, B);

Console.Write($"Результат возведения числа 'A'= {A} в степень 'B'= {B}: {result}");