/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

void SumOfNumsDigit()
   {
    Console.WriteLine("Введите целое число: ");
    string nu = Console.ReadLine();
    int i = 0;
    int sum = 0;
    int count = nu.Length;
    int[] mas = new int[count];
    while(i<count) 
    {
      char s = nu[i];
      mas[i] = s - '0';
      sum = mas[i]+sum;
      i++;
    } 

    Console.WriteLine("Сумма цифер в числе " + sum);
   }  
  
   SumOfNumsDigit();