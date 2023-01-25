// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Программа, которая выдаёт таблицу кубов чисел от 1 до N: ");

Console.Write("Введите число: ");

if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0) {
Console.WriteLine("Введен неверный параметр!");
return;
}

void powfunc(int N) {
    Console.WriteLine($"Введено число '{N}'");
    Console.Write($"Кубы чисел от 1 до {N}: ");
    int count = 1;
    Console.Write(Math.Pow(count, 3));
    count++;
    while(count <= N) {
    Console.Write(", " + Math.Pow(count, 3));
    count++;
    }
}

powfunc(N);