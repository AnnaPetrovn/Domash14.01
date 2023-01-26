/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int[] FillArr(int len, int a, int b)
{
    Console.WriteLine("Напишите число элементов массива");
    string g = Console.ReadLine();
    len = Convert.ToInt32(g);
    int [] arr = new int [len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}
void Printarr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("I Равно: " + i);
        Console.WriteLine(arr[i]);
    }
}
int[]array = FillArr(8,1,10);
Printarr(array);

