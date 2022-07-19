//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    if (number % 10 == number / 10000)
    {
        int secondStep = number / 10;
        double secondStep2 = secondStep % 1000;
        secondStep = Convert.ToInt32(secondStep2);

        if (secondStep % 10 == secondStep / 100)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else { Console.WriteLine("Число НЕ является палиндромом"); }
    }
    else { Console.WriteLine("Число НЕ является палиндромом"); }
}
else { Console.WriteLine("Число не пятизначное!"); }