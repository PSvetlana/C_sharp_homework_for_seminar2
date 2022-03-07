/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int GetSecondLetterOfNumber(int number) //вычислет вторую цифру числа
{
    int result = number / 10 % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber >= 100 && userNumber < 1000) //проверяем число на трехзначность
{
    int result = GetSecondLetterOfNumber(userNumber);
    Console.WriteLine($"У числа {userNumber} вторая цифра равна {result}");
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}

