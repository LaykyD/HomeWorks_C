// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

float[,] NewRandomFloatArray2D(int n, int m, int minvalue, int maxvalue){
	float[,] array = new float[n, m];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = (float)Math.Round(random.Next(minvalue, maxvalue + 1) + random.NextSingle(), 2);

return array;
}

void PrintArray2D(float[,] array) {
for (int i = 0; i < array.GetLength(0); i++) {
for (int j = 0; j < array.GetLength(1); j++)
Console.Write(array[i,j] + "  ");
Console.WriteLine();
}
}

(string, float) ElementValueToItemArray(float[,] array, int indexline, int indexcolumn){
    string str = "Такого числа в массиве нет!";
    float value = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++)
    if (i == indexline && j == indexcolumn){
        value = array[i, j];
        str = $"Значение елемента массива на позиции ({indexline}, {indexcolumn}) = ";
        return (str, value);
    }
}
    return (str, value);
}

void PrintResult(string str, float value){
    string finalstr = str;
    float finalvalue = value;
    if (finalvalue == 0) {
        Console.WriteLine(finalstr);
    }
    else Console.WriteLine(finalstr + finalvalue); 
}

Console.WriteLine("------------------------------------------------------------------------------------------------ ");
Console.WriteLine("Программа,создающая двумерный массив размером mxn, заполненный случайными вещественными числами: ");
Console.WriteLine("------------------------------------------------------------------------------------------------ ");

Console.Write("Введите количество столбцов матрицы: ");
int m = InputIntNumber();
Console.Write("Введите количество строк матрицы: ");
int n = InputIntNumber();
Console.Write("Введите минимальное значение диапазона генерации: ");
int minvalue = InputIntNumber();
Console.Write("Введите максимальное значение диапазона генерации: ");
int maxvalue = InputIntNumber();
Console.Write("Введите индекс строки массива: ");
int indexline = Math.Abs(InputIntNumber());
Console.Write("Введите индекс колонки массива: ");
int indexcolumn = Math.Abs(InputIntNumber());


var array = NewRandomFloatArray2D(n, m, minvalue, maxvalue);
PrintArray2D(array);
float finalvalue = ElementValueToItemArray(array, indexline, indexcolumn).Item2;
string finalstr = ElementValueToItemArray(array, indexline, indexcolumn).Item1;
PrintResult(finalstr, finalvalue);