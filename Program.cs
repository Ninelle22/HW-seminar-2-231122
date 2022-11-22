// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

using static System.Console;
Clear();

WriteLine("Insert number of the day of the week");
int n = Convert.ToInt32(ReadLine());
if (n == 7 || n == 6) 
    WriteLine("HOLIDAY");
else
    WriteLine("WEEKDAY");

    


