// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int input() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

int SumDigits(int num) {
    int sum = 0;
    while(Math.Abs(num) > 0) {
        sum = sum + Math.Abs(num) % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("------------------------------------------------------ ");
Console.WriteLine("Программа, определяющая сумму цифр во введенном числе: ");
Console.WriteLine("------------------------------------------------------ ");

Console.Write("Введите число: ");
int number = input();

//int number = new Random().Next(0, 1000000);

int result = SumDigits(number);

Console.Write($"Сумма цифр в числе {number} равна: {result}");