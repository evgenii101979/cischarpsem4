// Задача 30: Напишите программу, которая выводит массив из 
//8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

//Вариант 1
//Console.Clear();
//int n = 8;
//int[] arr = new int[n];
//Random rand = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//arr[i] = rand.Next(0,2);
//}
//Console.WriteLine(string.Join(", ", arr));

//Вариант 2

int[] Random01(int[] array_local)
{
    Random rnd = new Random();
    for (int i = 0; i < array_local.Length; i++)
    {
        array_local[i] = rnd.Next(0, 2);
    }
    return array_local;
}
int[] array = new int[8];
array = Random01(array);
Console.Write(String.Join(",",array));

//Вариант 3

//Console.Clear();
//int[] array = new int[8];
//for (int i = 0; i < array.Length; i++)
//{
//array[i] = new Random().Next(0, 2);
//Console.Write(array[i] + " ");
//}