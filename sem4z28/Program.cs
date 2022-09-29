// Задача 28: Напишите программу, которая принимает на вход число 
//N и M и выдаёт произведение чисел от M до N.
//2,4 -> 24
//1,5 -> 120

Console.Clear();
Console.WriteLine("Введите число 1:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int N = int.Parse(Console.ReadLine());
int A(int M)
{
    int result = 1;
    for (int i = M; i <= N; i++)
    {
        result = result * i;
    }
    return result;
}
Console.WriteLine($"Произведение от {M} до {N} = {A(M)}");
