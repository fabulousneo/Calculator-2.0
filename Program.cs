Console.WriteLine("Калькулятор");

Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine());

Console.Write("Выбери действие: 1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление");
string choise = Console.ReadLine();

switch (choise) {
    case "1": sum(a, b);
    break;
    
    case "2": difference(a, b);
    break;
    
    case "3": multiplication(a, b);
    break;
    
    case "4": division(a, b);
    break;
    
    default:
        Console.WriteLine("Неверные данные");
        break;
}
    
void sum (int a, int b) // Функция, которая выполняет действие сложения
{
   int summ = a + b;
   Console.WriteLine("Сумма чисел равна: " + summ);
}
﻿void division (int a, int b) // Функция, выполняющая действие деление
{
    int div = a / b;
    Console.WriteLine("Деление чисел равно: " + div);
}

void multiplication (int a, int b) // Функция, выполняющая действие умножения
{
    int mult = a * b;
    Console.WriteLine("Произведение чисел равно: " + mult);
    }

void difference (int a, int b) // Функция, выполняющая действие разности
{
    int dif = a - b;
    Console.WriteLine("Разность чисел равна: " + dif);
}