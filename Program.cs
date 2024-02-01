// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

Console.WriteLine ("Input the M value");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input the N value");
int N = Convert.ToInt32 (Console.ReadLine());
int min = M+1;
int max = N-1;
if (N < M)
{
    min = N+1;
    max = M-1;
}
Console.Write ("Numbers between the asked values are: ");
void printNumber (int i)
{
    if (i >  max)
    {
        return;
    }

    Console.Write (i + " ");
    printNumber (i+1);

}
printNumber(min);
Console.WriteLine();
Console.WriteLine();



// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.WriteLine ("Input the m value");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input the n value");
int n = Convert.ToInt32 (Console.ReadLine());
int A (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return A (m - 1, 1);
        }
        else
        {
            return A (m - 1, A (m, n - 1));
        }
    }
}
Console.WriteLine ("A=" + A(m,n));
Console.WriteLine();
// Код написан для формулы вида A(m,n), указанной в домашнем задании.
// Согласно формуле из Wikipedia, запись вида A(m,n) при m=2 и n=3 будет равна 9, а не ожидаемый в домашнем задании ответ 29.
// Для того, чтобы получился ответ из домашнего задания, в условиях нужно было указать A(n,m).



// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
int [] myArray = {3, 56, 34, 1, 5};
Console.Write ("The default array backwards is ");
void printArrayBackwards (int i)
{
    if (i < 0)
    {
        return;
    }
    Console.Write (myArray[i] + " ");
    printArrayBackwards (i-1);
}
printArrayBackwards (myArray.Length-1);
