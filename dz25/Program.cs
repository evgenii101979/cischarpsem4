/* Задача 25: Напишите цикл, который принимает на 
вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int N = int.Parse(Console.ReadLine());
int B(int A)
{
    int result = 1;
    for (int i = A; i <= N; i++)
    {
        result = Convert.ToInt32(Math.Pow(A, N));;
    }
    return result;
}
Console.WriteLine($"Возведение числа {A} в степень {N} = {Math.Pow(A, N)}");