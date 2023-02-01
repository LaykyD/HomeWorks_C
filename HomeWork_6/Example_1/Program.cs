// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int input() {
//     int res;
//     while (!int.TryParse(Console.ReadLine(), out res))
//     {
//         Console.WriteLine("Введен неверный параметр! Введите целое число...");
//     }
//      return res;   
// }

// int[] InputSequentiallyArray(int discharge){
// 	int[] arr = new int[discharge];
// 	for (int i = 0; i < arr.Length; i++)
// 	{
//     Console.Write($"Введите число № {i+1}... ");
// 	arr[i] = input();
// 	}
// 	return arr;
// }

int[] InputToStringArray(string str){
    string[] arrstr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] arrint = arrstr.Select(int.Parse).ToArray();
	return arrint;
}

int AmountNumberGreater0(int[] arr){
    int result = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] > 0) result += 1;
    }
    return result;
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

Console.WriteLine("----------------------------------------------------------------- ");
Console.WriteLine("Программа, считающая сколько чисел больше нуля ввел пользователь: ");
Console.WriteLine("----------------------------------------------------------------- ");

// Вариант с вводом последовательного каждого из чисел:
// Console.Write("Введите общее количество чисел: ");

// int discharge = Math.Abs(input());
// Console.WriteLine("Введите числа для сравнения: ");
// int[] array = InputSequentiallyArray(discharge);


// Вариант с вводом чисел в строку через пробел:
// Пока нет "защиты от дурака", при вводе не чисел программа падает...

Console.Write("Введите !!ЧЕРЕЗ ПРОБЕЛ!! числа для сравнения: ");
string str = Console.ReadLine();
int[] array = InputToStringArray(str);


PrintArray(array);
Console.WriteLine("Количество чисел больше нуля: " + AmountNumberGreater0(array));