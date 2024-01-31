int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int resultNum = firstDigit * 10 + thirdDigit;
    return resultNum;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число: {number}");

int number1 = RemoveSecondDigit(number);
Console.WriteLine($"Число после удаления цифры: {number1}");