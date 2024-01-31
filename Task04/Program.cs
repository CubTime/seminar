Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int negative = -number;

while (negative <= number)
{
    Console.Write($"{negative} ");
    negative++;
}