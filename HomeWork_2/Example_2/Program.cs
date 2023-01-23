// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 100 != number) 
    {
        int thirdDigit = number;
        while(thirdDigit > 100) 
        {
            if (thirdDigit > 1000)
                {
                    thirdDigit = thirdDigit / 10;
                }
            else thirdDigit = thirdDigit % 10;
        }

    Console.WriteLine("Третья цифра вашего числа: " + thirdDigit);
    }
else Console.WriteLine("Третьей цифры в числе нет.");