// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
     return res;   
}

int InputTwoDigitIntNumber() {
    int res;
    while (!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Введен неверный параметр! Введите целое число...");
    }
    if (res >= 10 && res < 100){
        return res;
    }
    else {
        Console.WriteLine("Введено не двухзначное число! Введите целое двухзначное число...");
        InputTwoDigitIntNumber();
    }
     return res;   
}

int GetUniqueValue(int[,,] array3D, int minvalue, int maxvalue, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    Random random = new Random();
    while (exist)
    {
        bool _break = false;
        value = random.Next(minvalue, maxvalue + 1);
        for (int i1 = 0; i1 < array3D.GetLength(0); i1++){
            if (_break) { break; }
            for (int j1 = 0; j1 < array3D.GetLength(1); j1++){
                if (_break) { break; }
                for (int k1 = 0; k1 < array3D.GetLength(2); k1++){
                    if (array3D[i1, j1, k1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}

int[,,] NewRandomIntArray3D(int x, int y, int z, int minvalue, int maxvalue){
    int[,,] array3D = new int[x, y, z];
    Random random = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++){
        for (int j = 0; j < array3D.GetLength(1); j++){
            for (int k = 0; k < array3D.GetLength(2); k++){
                array3D[i, j, k] = GetUniqueValue(array3D, minvalue, maxvalue, i, j, k);
            }
        }
    }
    return array3D;
}

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++){
        for (int j = 0; j < array3D.GetLength(1); j++){
            Console.Write("| ");
            for (int k = 0; k < array3D.GetLength(2); k++){ 
                Console.Write($"{array3D[i, j, k],1} ({i},{j},{k})| "); 
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("----------------------------------------------------------------------------------- ");
Console.WriteLine("Программа,которая формирует трёхмерный массив из неповторяющихся двузначных чисел.: ");
Console.WriteLine("----------------------------------------------------------------------------------- ");

Console.WriteLine("Введите размер массива X x Y x Z: ");
Console.Write("Введите X: ");
int x = InputIntNumber();
Console.Write("Введите Y: ");
int y = InputIntNumber();
Console.Write("Введите Z: ");
int z = InputIntNumber();

Console.Write("Введите минимальное значение диапазона генерации: ");
int minvalue = InputTwoDigitIntNumber();
Console.Write("Введите максимальное значение диапазона генерации: ");
int maxvalue = InputTwoDigitIntNumber();

int[,,] array3D = NewRandomIntArray3D(x, y, z ,minvalue, maxvalue);
PrintArray3D(array3D);



