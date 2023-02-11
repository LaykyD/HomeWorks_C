// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumSingleArray(int[] array){
    int sum = 0;
        for (int i = 0; i < array.Length; i++){
            sum += array[i];
        }
    return sum;
}

(int, int) IndexMinToArray (int[] array) {
    int min = array[0];
    int indexmin = 0;
    for (int i = 1; i < array.Length; i++){
        if (min > array[i]) {
            min = array[i];
            indexmin = i;
        }
	}
return (indexmin, min);
}

(int, int) NumberRowMinSumToArray(int[,] array){
    int[] tmparray = new int[array.GetLength(1)];
    int[] sumarray = new int[array.GetLength(0)];
    int numberrow = 0;
    int minsumrow = 0;
    for (int i = 0; i < array.GetLength(0); i++){    
        for (int j = 0; j < array.GetLength(1); j++){
            tmparray[j] = array[i, j];            
        }   
        sumarray[i] = SumSingleArray(tmparray);
        numberrow = IndexMinToArray(sumarray).Item1 + 1;
        minsumrow = IndexMinToArray(sumarray).Item2;
    }
    return (numberrow, minsumrow);
}

Console.WriteLine("-------------------------------------------------------------------------------------------------------------- ");
Console.WriteLine("Программа,которая считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: ");
Console.WriteLine("-------------------------------------------------------------------------------------------------------------- ");

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
Console.WriteLine($"Наименьшая сумма элементов '{NumberRowMinSumToArray(array).Item2}' в строке № {NumberRowMinSumToArray(array).Item1}");
