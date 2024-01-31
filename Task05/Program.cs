Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastnumber = number % 10;

if (number > 999)
{
    Console.Write("Invalid number");
}
else if(number < 100)
{
    Console.Write("Invalid number");
}
else
{
    Console.Write($"Последняя цифра числа: {lastnumber}");
}