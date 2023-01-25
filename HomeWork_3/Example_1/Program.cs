// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
//(НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Программа, определяющая является ли пятизначное число палиндромом: ");

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000) {
        CheckPalindrome(number);
}
else {
    Console.WriteLine("Введено не пятизначное число!");
    return;
}

bool CheckPalindrome(int nunmber) {
    int firstDigit =  number / 10000;
    int secondDigit = (number / 1000) % 10;
    int fourthDigit = (number / 10) % 10;
    int fifthDigit = number % 10;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    return true;
    else 
    return false;
}

if (CheckPalindrome(number))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");