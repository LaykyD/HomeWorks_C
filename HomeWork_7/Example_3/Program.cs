// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

int[,] NewRandomIntArray2D(int n, int m, int minvalue, int maxvalue){
	int[,] array = new int[n, m];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = random.Next(minvalue, maxvalue + 1);

return array;
}

void PrintArray2D(int[,] array) {
for (int i = 0; i < array.GetLength(0); i++) {
for (int j = 0; j < array.GetLength(1); j++)
Console.Write(array[i,j] + "  ");
Console.WriteLine();
}
}

void PrintArray(double[] array) {
for (int i = 0; i < array.GetLength(0); i++) {
Console.Write(array[i] + "  ");
}
}

double[] ArithmeticMeanColumnsArray(int[,] array){
    double[] resultarray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++){
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++){
            average += array[i, j];
            resultarray[j] = average / array.GetLength(0);
        }
    }
    return resultarray;
}

Console.WriteLine("----------------------------------------------------------------------------------------- ");
Console.WriteLine("Программа,находящая среднее арифметическое элементов в каждом столбце двумерного массива: ");
Console.WriteLine("----------------------------------------------------------------------------------------- ");

Console.Write("Введите количество столбцов массива ");
int m = InputIntNumber();
Console.Write("Введите количество строк массива: ");
int n = InputIntNumber();
Console.Write("Введите минимальное значение диапазона генерации: ");
int minvalue = InputIntNumber();
Console.Write("Введите максимальное значение диапазона генерации: ");
int maxvalue = InputIntNumber();


var array = NewRandomIntArray2D(n, m, minvalue, maxvalue);
Console.WriteLine("Сгенерированный массив: ");
PrintArray2D(array);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
PrintArray(ArithmeticMeanColumnsArray(array));
