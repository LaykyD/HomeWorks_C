// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

Console.WriteLine("------------------------------------------------------------------------------------------------ ");
Console.WriteLine("Программа,создающая двумерный массив размером mxn, заполненный случайными вещественными числами: ");
Console.WriteLine("------------------------------------------------------------------------------------------------ ");

Console.Write("Введите количество столбцов матрицы: ");
int m = InputIntNumber();
Console.Write("Введите количество строк матрицы: ");
int n = InputIntNumber();
Console.Write("Введите минимальное значение диапазона генерации: ");
int minvalue = InputIntNumber();
Console.Write("Введите максимальное значение диапазона генерации:");
int maxvalue = InputIntNumber();

var array = NewRandomFloatArray2D(n, m, minvalue, maxvalue);
PrintArray2D(array);