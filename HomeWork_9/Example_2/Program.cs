// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

void SumNaturalNumbersRangeFromMToN(int m, int n, int sum){
if (m > n) {
    sum = 0;
    Console.Write($"Сумма элементов = {sum} ");
    return;
}
  sum = sum + n;
  if (n <= m){
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  SumNaturalNumbersRangeFromMToN(m, n - 1, sum);
}

Console.WriteLine("------------------------------------------------------------------------------ ");
Console.WriteLine("Программа, которая нахолит сумму натуральных элементов в промежутке от M до N: ");
Console.WriteLine("------------------------------------------------------------------------------ ");

Console.Write("Введите число M: ");
int numberM = InputIntNumber();
Console.Write("Введите число N: ");
int numberN = InputIntNumber();
int sum = 0;

SumNaturalNumbersRangeFromMToN(numberM, numberN, sum);