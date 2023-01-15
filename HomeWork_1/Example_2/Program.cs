// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;

if ((number1 > number2) && (number1 > number3))
{
    max = number1;
    Console.WriteLine("Первое число " + number1 + " больше второго числа " + number2 + " и больше третьего числа " + number3 + ". Максимум = " + max);
}
else if ((number2 > number1) && (number2 > number3))
{
    max = number2;
    Console.WriteLine("Второе число " + number2 + " больше первого числа " + number1 + " и больше третьего числа " + number3 + ". Максимум = " + max);
}
else if ((number3 > number1) && (number3 > number2))
{
    max = number3;
    Console.WriteLine("Третье число " + number3 + " больше первого числа " + number1 + " и больше второго числа " + number2 + ". Максимум = " + max);
}
else {
    Console.WriteLine("Числа равны между собой!");
}