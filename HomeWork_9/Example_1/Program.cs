// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

void NaturalNumbersRangeFromNTo1(int n, int finishnumber){
    if (finishnumber > n){
        return;
    }
    else{
        NaturalNumbersRangeFromNTo1(n, finishnumber + 1);
        Console.Write(finishnumber + " ");
    }
}

Console.WriteLine("------------------------------------------------------------------------ ");
Console.WriteLine("Программа, которая выводит все натуральные числа в промежутке от N до 1: ");
Console.WriteLine("------------------------------------------------------------------------ ");

Console.Write("Введите число N: ");
int number = InputIntNumber();
int finishnumber = 1;
NaturalNumbersRangeFromNTo1(number, finishnumber);
