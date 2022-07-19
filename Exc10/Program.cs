Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.WriteLine ("Неверное число");
    n = Convert.ToInt32(Console.ReadLine());
}
int a = n % 100 ;
Console.WriteLine ("Вторая цифра числа:");
Console.WriteLine (a / 10);