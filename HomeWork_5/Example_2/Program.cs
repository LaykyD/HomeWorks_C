// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int input() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

int[] NewRandomArray(int discharge){
	int[] arr = new int[discharge];
	for (int i = 0; i < arr.Length; i++)
	{
    arr[i] = new Random().Next(-999, 1000);
	}
	return arr;
}

int SumNumberOddToArray (int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
        if (i % 2 == 0) {
            sum += arr[i];
        }
	}
    return sum;
}

void PrintArray(int[] arr){
    Console.Write($"Ваш массив, состоящий из {arr.Length} элементов: [");
	for (int i = 0; i < arr.Length; i++){
        if (i == arr.Length -1)
        Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
	}
    Console.WriteLine();
}

Console.WriteLine("--------------------------------------------------------------------------- ");
Console.WriteLine("Программа, считающая сумму элементов массива, стоящих на нечётных позициях: ");
Console.WriteLine("--------------------------------------------------------------------------- ");

Console.Write("Введите разрядность массива: ");
int discharge = Math.Abs(input());
int[] array = NewRandomArray(discharge);

PrintArray(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве: " + SumNumberOddToArray(array));