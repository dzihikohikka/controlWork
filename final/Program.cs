// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("text letgth of massive");
int len = int.Parse(Console.ReadLine()!);


string [] arr1 = new string [len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine("text element");
    arr1[i] = Console.ReadLine();
}

void Print(string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine();
Print(arr1);

string [] arr2 = new string [len];

void Chek3(string [] arr, string [] arra)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            arra[i] = arr[i];
        }
    }
}

Console.WriteLine();
Chek3(arr1,arr2);
Print(arr2);