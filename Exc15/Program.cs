int n;

Console.WriteLine ("Введите номер дня недели");
n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 7) 
{ 
    if (n == 1)  Console.WriteLine ("Нет");
    if (n == 2)  Console.WriteLine ("Нет");
    if (n == 3)  Console.WriteLine ("Нет");
    if (n == 4)  Console.WriteLine ("Нет");
    if (n == 5)  Console.WriteLine ("Нет");
    if (n == 6)  Console.WriteLine ("Да");
    if (n == 7)  Console.WriteLine ("Да");
}
else 
{
    Console.WriteLine ("Ты ошибся...");
}