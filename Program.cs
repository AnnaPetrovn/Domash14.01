/*
Напишите цикл, который принимает на вход два числа (A  и B) и возводит число A (number) в натуральную степень B(degree).

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

void DegreeFinding(double number, double degree)
{
  double result = Math.Pow(number, degree);
  Console.WriteLine($"{result}");
}

DegreeFinding(5, 4);





/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

void SumOfNumsDigit()
   {
    Console.WriteLine("Введите целое число:");
    string nu = Console.ReadLine();
    int i = 0;
    int j = 0;
    int count = nu.Length;
    int[] mas = new int[count];
    while(i<count) 
    {
      char s = nu[i];
      mas[i] = s - '0';
      j = mas[i]+j;
      i++;
    } 

    Console.WriteLine("Сумма цифер в числе " + j);
   }  
  
   SumOfNumsDigit();
   /*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

void PrintOfElements ()
{ 
  for (int i=1; i<=8; i++)
{
   Random rnd = new Random ();
  int arr = rnd.Next(1,100);
  Console.Write(arr + "|");
}
}

PrintOfElements();*/