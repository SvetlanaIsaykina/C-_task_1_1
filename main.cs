using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Введите первое число: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write ("Введите второе число: ");
    int number2 = int.Parse(Console.ReadLine());

    if (number1 > number2)
    {
      Console.WriteLine ($"Большее число: {number1}");
      Console.WriteLine ($"Меньшее число: {number2}");
    }
    else
    {
      Console.WriteLine ($"Большее число: {number2}");
      Console.WriteLine ($"Меньшее число: {number1}");
    }
  }
}