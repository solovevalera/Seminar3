// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Ввести пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numbersave = number;
int revnumber = 0;


while (number > 0);
{
    int dig = number % 10;
    revnumber = revnumber * 10 + dig;
    number = number / 10;
}
if (numbersave == revnumber)
{
Console.WriteLine("Палиндром");
}
else
{
Console.WriteLine("Палиндром");
}
