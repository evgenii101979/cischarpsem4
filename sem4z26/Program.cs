// Задача 26: Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

// Решение 1 (для 10-ти и более значных чисел не работает)
//using System;
//internal class Program
//{
  //  private static void Main(string[] args)
    //{
      //  Console.WriteLine("Введите число: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //num_count(num);
        //void num_count(int num1)
        //{
          //  int count = 0;
            //while (num1 != 0)
            //{
              //  num1 = num1 / 10;
                //count++;
            //}
            //Console.WriteLine(count);
        //}
    //}
//}

// Решение 2 (для 10-ти и более значных чисел не работает)
//Console.Clear();
//Console.Write("Введите число: ");
//int x = int.Parse(Console.ReadLine());

//int Numbers (int x) 
//{
    //int result = 0;
    //if (x == 0) result = 1;
    //for (int i = 1; i < x; i++) 
    //{
        //if (x % i >= 0) 
        //{
            //result += 1;
            //i = i * 10;
        //}
    //}
    //return result;
//}
//Console.WriteLine($"В веденном числе {Numbers(x)} цифр(а)");

// Решение 3 (работает полностью)
//Console.Clear();
//Console.WriteLine("Введите число:");
//string number = Console.ReadLine();
//int limit = number.Length;
//Console.WriteLine($"Количество цифр в числе: {limit}");


// Решение 4 (работает полностью)
using System;
internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Введите число: ");
      string num = (Console.ReadLine());
      Console.WriteLine(num.Length);
    }
}