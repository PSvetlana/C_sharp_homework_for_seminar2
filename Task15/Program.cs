/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
 */

string CheckWeekend(int number) //проверка на выходной день
{
    string result = "";
    if (number == 6 || number == 7)
    {
        result = "Да, это выходной день.";
    }
    else
    {
        result = "Нет, это рабочий день.";
    }
    return result;
}

Console.Write("Введите число от 1 до 7: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber < 1 || userNumber > 7)
{
    Console.Write("Введенное число не входит в диапазон от 1 до 7!");
}
else
{
    string result = CheckWeekend(userNumber);
    Console.WriteLine($"{userNumber} - {result}");
}