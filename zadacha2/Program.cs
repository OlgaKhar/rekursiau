//Задача 2: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.


static int Akkehmane(int m, int n) 
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akkehmane(m - 1, 1);
    else return Akkehmane(m - 1, Akkehmane(m, n - 1));
}


 Console.Write("Введите число m: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число n: ");
 int n = Convert.ToInt32(Console.ReadLine());

int e = Akkehmane(m, n);
 Console.WriteLine(e);

