// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

float[] NewRandomFloatArray(int discharge){
	float[] arr = new float[discharge];
	for (int i = 0; i < arr.Length; i++)
	{
    arr[i] = (float)new Random().NextDouble()*10;
	}
	return arr;
}

float DiffMaxMinToArray (float[] arr) {
    float min = arr[0];
    float max = arr[0];
    for (int i = 1; i < arr.Length; i++){
        if (max < arr[i]) {
            max = arr[i];
        }
        if (min > arr[i]) {
            min = arr[i];
        }
	}

    Console.WriteLine("Max = " + max);
    Console.WriteLine("Min = " + min);
    float diff = max - min;
    return diff;
}

void PrintArray(float[] arr){
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
int discharge = Math.Abs(InputIntNumber());
float[] array = NewRandomFloatArray(discharge);

PrintArray(array);
Console.WriteLine($"Разница между максимальным и мининимальным элементами в массиве: {DiffMaxMinToArray(array)}");