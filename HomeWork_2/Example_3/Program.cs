// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 7 && day >= 1) 
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день!");
    }
    else Console.WriteLine("Рабочий день!");

    // Второй вариант решения (с отображением конкретного дня недели):

    // switch (day)
    // {
    //     case 1:
    //     Console.WriteLine("Понедельник - рабочий день.");
    //     break;
        
    //     case 2:
    //     Console.WriteLine("Вторник - рабочий день.");
    //     break;

    //     case 3:
    //     Console.WriteLine("Среда - рабочий день.");
    //     break;

    //     case 4:
    //     Console.WriteLine("Четверг - рабочий день.");
    //     break;

    //     case 5:
    //     Console.WriteLine("Пятница - рабочий день.");
    //     break;

    //     case 6:
    //     Console.WriteLine("Суббота - выходной день!");
    //     break;

    //     case 7:
    //     Console.WriteLine("Воскресенье - выходной день!");
    //     break;
    // }
}
else Console.WriteLine("Введена некорректная цифра! Введите цифру от 1 до 7");