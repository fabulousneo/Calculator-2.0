Console.WriteLine("Калькулятор");

Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine());

Console.Write("Выбери действие: 1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление");
string choise = Console.ReadLine();

switch (choise) {
    case "1": Console.WriteLine(summ(a, b));
    break;
    case "2": Console.WriteLine(summ(a, b));
    break;
    case "3": Console.WriteLine(summ(a, b));
    break;
    case "4": Console.WriteLine(summ(a, b));
    break;
}
    