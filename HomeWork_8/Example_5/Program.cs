// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

int[,] SpiralArray(int rowcol){
    int[,] array = new int[rowcol, rowcol];
    int i = 0, j = 0;
    int value = 1;
    while (value <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}

void PrintArray2D(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
        if(array[i, j] < 10) {
            Console.Write("0" + array[i,j] + "  ");
        }
        else {
            Console.Write(array[i,j] + "  ");
        }    
        Console.WriteLine();       
    }
}

Console.WriteLine("---------------------------------------------- ");
Console.WriteLine("Программа, которая заполняет спирально массив: ");
Console.WriteLine("---------------------------------------------- ");

Console.Write("Введите разрядность массива: ");
int rowcol = InputIntNumber();
PrintArray2D(SpiralArray(rowcol));