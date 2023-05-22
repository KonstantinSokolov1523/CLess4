/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/
/*
Console.Write("введите число А: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int Expo = Convert.ToInt32(Console.ReadLine());
int NumExpon(int A, int B)
{
    int expon = 1; 
    for(int i = 0; i < B; i++)
    {
        expon *=A;
    }
    return expon;
}
Console.WriteLine(NumExpon(Num, Expo));
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int SumInN(int N)
{
sum = 0;

for(int i = N; i > 0; N /= 10)
{
sum += N%10;
}
return sum;
}
Console.WriteLine(SumInN(N));

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

