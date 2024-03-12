//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы


string GetListNatNums(int num, int num2)
{
    if (num == num2)
    { return Convert.ToString(num); }
    return num + " " + GetListNatNums(num + 1, num2);   
}


Console.Write("Введите натуральное число N: ");
int num = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите натуральное число M: ");
int num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(GetListNatNums(num, num2));


