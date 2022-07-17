// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");

string? number = Console.ReadLine();

void DigitsNuber(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - это палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - это не палиндром.");
}

if (number!.Length == 5)
{
  DigitsNuber(number);
}
else Console.WriteLine($"Это не пятизначное число");