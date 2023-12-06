Console.Write("Введите корень: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите корень этого числа: ");
double x2 = Convert.ToDouble(Console.ReadLine());

if (x1 == x2 * x2) Console.WriteLine($"{x2} x {x2} = {x1}, True!");
else if (x1 != x2 * x2) Console.WriteLine($"{x2} x {x2} ≠ {x1}, False!");
else Console.WriteLine("Вы ввели неверное число!");