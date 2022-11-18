// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int recursion(int m, int n)
{
    // 1
    if (m == 0)
    {
        return n + 1;
    }
    // 2
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    }
    // 3
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}

void Print(int m, int n)
{
    Console.WriteLine("m = " + $"{m}, "+"n = " + $"{n}" + " -> A(m,n) = " + recursion(m, n));
}

int m = 3;
int n = 2;
Print(m, n);



