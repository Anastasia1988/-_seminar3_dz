// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = {0,0,0,0,0};

if (number > 9999 && number < 100000)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}
else
{
Console.WriteLine("Введено не пятизначное число");
}

