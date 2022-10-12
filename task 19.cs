// Напишите программу, которая на вход принимает пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int n)
{
    if (n / 10000 == n % 10 && (n / 1000) % 10 == (n / 10) % 10);
    {
       Console.WriteLine("Да"); 
    }
    else
    {
       Console.WriteLine("Нет"); 
    }
}
       
Console.Clear();
Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
Palindrome(N);

