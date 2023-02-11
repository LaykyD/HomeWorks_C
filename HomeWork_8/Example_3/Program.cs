// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductOfTwoMatrices(int[,] array1, int[,] array2){
    int[,] resultarray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) != array2.GetLength(0)) {
        Console.WriteLine("Заданы неверные матрицы! Умножение невозможно!");
    }
    else {
        for (int i = 0; i < resultarray.GetLength(0); i++) {
            for (int j = 0; j < resultarray.GetLength(1); j++){
                int result = 0;
                for (int k = 0; k < array1.GetLength(1); k++){
                result += array1[i,k] * array2[k,j];
                }
                resultarray[i,j] = result;
            }
        }
    }
    return resultarray;
}

Console.WriteLine("----------------------------------------------------------- ");
Console.WriteLine("Программа,которая которая находит произведение двух матриц: ");
Console.WriteLine("----------------------------------------------------------- ");

Console.Write("Введите количество столбцов первой матрицы: ");
int row1 = InputIntNumber();
Console.Write("Введите количество строк первой матрицы: ");
int column1 = InputIntNumber();
Console.Write("Введите количество столбцов второй матрицы: ");
int row2 = InputIntNumber();
Console.Write("Введите количество строк второй матрицы: ");
int column2 = InputIntNumber();
Console.Write("Введите минимальное значение диапазона генерации: ");
int minvalue = InputIntNumber();
Console.Write("Введите максимальное значение диапазона генерации: ");
int maxvalue = InputIntNumber();


var array1 = NewRandomIntArray2D(column1, row1, minvalue, maxvalue);
Console.WriteLine("Первая сгенерированная матрица: ");
PrintArray2D(array1);

var array2 = NewRandomIntArray2D(column2, row2, minvalue, maxvalue);
Console.WriteLine("Вторая сгенерированная матрица: ");
PrintArray2D(array2);

Console.WriteLine("Итоговая матрица: ");
PrintArray2D(ProductOfTwoMatrices(array1, array2));
