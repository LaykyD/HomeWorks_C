// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// заданных уравнениями y = a * x + c, y = b * x + d;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double input() {
    double res;
    while (!double.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

(string, double, double) Intercept2Line(double k1, double b1, double k2, double b2){
double x = 0;
double y = 0;
string str = string.Empty;
if (k1 != k2) {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    str = "Прямые пересекаются в точке";
}
else {
    if (b1 != b2) {
        str = "Прямые параллельны!";
    }
    else{
        str = "Прямые совпадают!";
    }
}
return(str, x, y);
}

string PrintResult(string str, double x, double y){
    string strresult = string.Empty;
    if (str == "Прямые пересекаются в точке"){
        strresult = $"{str}: ({x};{y})";
    }
    else {
     strresult = str;
    }
    return strresult;
}

Console.WriteLine("--------------------------------------------------- ");
Console.WriteLine("Программа, находящая точку пересечения двух прямых: ");
Console.WriteLine("--------------------------------------------------- ");

Console.Write("Введите k1: ");
double k1 = input();
Console.Write("Введите b1: ");
double b1 = input();
Console.Write("Введите k2: ");
double k2 = input();
Console.Write("Введите b2: ");
double b2 = input();

double x = Math.Round(Intercept2Line(k1, b1, k2, b2).Item2, 3);
double y = Math.Round(Intercept2Line(k1, b1, k2, b2).Item3, 3);
string str = Intercept2Line(k1, b1, k2, b2).Item1;

Console.WriteLine(PrintResult(str, x, y));
 