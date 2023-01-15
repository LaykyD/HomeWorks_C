// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max;

if (number1 > number2)
{
    max = number1;
    Console.WriteLine("Первое число " + number1 + " больше второго числа " + number2 + ". Максимум = " + max);
}
else if (number1 < number2)
{
    max = number2;
    Console.WriteLine("Второе число " + number2 + " больше первого числа " + number1 + ". Максимум = " + max);
}
else {
    Console.WriteLine("Числа равны");
}