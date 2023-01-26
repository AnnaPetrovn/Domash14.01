/*
Напишите цикл, который принимает на вход два числа (A  и B) и возводит число A (number) в натуральную степень B(degree).

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

double DegreeFind()
{
    Console.WriteLine("Напишите число, которое нужно возвести в степень ");
    string h = Console.ReadLine();
    Console.WriteLine("Напишите натуральное число, которое будет являться значением степени ");
    string n  = Console.ReadLine();
    double a = Convert.ToDouble(h);
    int b = Convert.ToInt32(n);
    double result = 1;
    for(int i = 1; i<=b; i++)
    {
        result = result*a;
    }
    Console.WriteLine("Результат числа, возведенного в степень равно: " + result);
    return result;
}

double res =DegreeFind();
