// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int input() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

int[] NewArray(int discharge){
	int[] arr = new int[discharge];
	for (int i = 0; i < arr.Length; i++)
	{
    arr[i] = new Random().Next(100, 1000);
	}
	return arr;
}

int NumberEvenToArray (int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] % 2 == 0) {
            count++;
        }
	}
    return count;
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

Console.WriteLine("---------------------------------------------------------- ");
Console.WriteLine("Программа, показывающая количество чётных чисел в массиве: ");
Console.WriteLine("---------------------------------------------------------- ");

Console.Write("Введите разрядность массива: ");
int discharge = Math.Abs(input());
int[] array = NewArray(discharge);

PrintArray(array);
Console.WriteLine("Количество четных чисел в массиве: " + NumberEvenToArray(array));

