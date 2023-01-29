// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

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
    Console.Write($"Введите элемент массива под номером {i+1}... ");
	arr[i] = input();
    //arr[i] = new Random().Next(-100, 100);
	}
	return arr;
}

void PrintArray(int[] arr){
    Console.Write($"Ваш массив, состоящий из {arr.Length} элементов: [");
	for (int i = 0; i < arr.Length; i++){
        if (i == arr.Length -1)
        Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
	}
}

Console.WriteLine("---------------------------------------------------- ");
Console.WriteLine("Программа, задающая массив и выводящая его на экран: ");
Console.WriteLine("---------------------------------------------------- ");

Console.Write("Введите разрядность массива: ");
int discharge = Math.Abs(input());

PrintArray(NewArray(discharge));
