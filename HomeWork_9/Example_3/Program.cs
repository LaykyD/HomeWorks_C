// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

int Ackkerman(int m, int n){
  if (m == 0) return n + 1;
  else if (n == 0) return Ackkerman(m - 1, 1);
  else return Ackkerman(m - 1, Ackkerman(m, n - 1));
}

Console.WriteLine("------------------------------------- ");
Console.WriteLine("Программа вычисления функции Аккермана: ");
Console.WriteLine("------------------------------------- ");

Console.Write("Введите число M: ");
int numberM = Math.Abs(InputIntNumber());
Console.Write("Введите число N: ");
int numberN = Math.Abs(InputIntNumber());

Console.WriteLine($"Результат функции Аккермана для чисел '{numberM}' и '{numberN}' = {Ackkerman(numberM, numberN)}");
