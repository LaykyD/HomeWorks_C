//
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortSingleArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++){
            if (array[j] < array[j + 1]){
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}

void SingleToDubleArray(int row, int[] singlearray, int[,] doublearray){
    for (int i = 0; i < singlearray.Length; i++){
        doublearray[row, i] = singlearray[i];
    }
}

int[,] SortDecreasingRowArray(int[,] array){
    int[] tmparray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            tmparray[j] = array[i, j];            
        }       
        SortSingleArray(tmparray);
        SingleToDubleArray(i, tmparray, array);
    }
    return array;
}

Console.WriteLine("----------------------------------------------------------------------------------- ");
Console.WriteLine("Программа,которая упорядочит по убыванию элементы каждой строки двумерного массива: ");
Console.WriteLine("----------------------------------------------------------------------------------- ");

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
Console.WriteLine("Массив с упорядоченными элементами: ");
PrintArray2D(SortDecreasingRowArray(array));