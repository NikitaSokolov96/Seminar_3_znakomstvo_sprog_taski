// Задача 23. 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int x (int x)

 {

    int l = x * x * x;

    return l;
}

void cube (int n) 

{ 
    Console.Write($"{n} -> ");

    for (int i = 1; i < n ; i++)
     {

        Console.Write($"{x(i)}, ");

    }

    Console.Write($"{x(n)} ");

}

Console.WriteLine("Введите целое число больше 2:");
int number = Convert.ToInt32(Console.ReadLine());
cube(number);