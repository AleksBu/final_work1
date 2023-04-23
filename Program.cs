// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Print(string[] arr)
{
    string size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

string[] MassNums(int size, int from, int to)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
        arr[i] = string.Parse(Console.ReadLine()!);
    return arr;
}

void SumPosNeg(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = - arr[i];
        
    }
    
} 


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

string[] mass1 = MassNums(num, start, stop);
Print(mass1);
SumPosNeg(mass1);
Print(mass1);