Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if( n > 99) Console.WriteLine((n / 100) % 10);
else
{
    Console.WriteLine ("нет третьей цифры");
}


