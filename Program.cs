try {
    Console.WriteLine("Введите размер массива: ");
    int n = Int32.Parse(Console.ReadLine());

    var rand = new Random();
    int[] mass = new int[n];

    for (int i = 0; i < n; i++)
        mass[i] = rand.Next(-100, 100);
    
    Console.Write("Ваш массив: ");

    foreach(var item in mass)
    {
        Console.Write(item.ToString() + " ");
    }

    Array.Reverse(mass);

    Console.Write("\nВаш массив в обратном порядке: ");
    
    foreach(var item in mass)
    {
        Console.Write(item.ToString() + " ");
    }

}
catch {
    Console.WriteLine("Неверный ввод размера массива");
}
// Проверка изменений в файле