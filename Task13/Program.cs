/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int GetThirdLetterOfNumber(int number) //вычисляет третью цифру числа
{
    //int result = number; - лишняя строчка
    while (number >= 1000) //приводим число к трехзначному
    {
        number /= 10;
    }
    int result = number % 10;
    return result;
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100)
{
    Console.WriteLine("В данном числе нет третьей цифры!");
}
else
{
    int result = GetThirdLetterOfNumber(userNumber);
    Console.WriteLine($"У числа {userNumber} третья цифра {result}");
}

