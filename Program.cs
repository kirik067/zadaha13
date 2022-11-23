Console.WriteLine("Видите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{ 
    while (num > 999)
    {
    num /= 10;
    }
    Console.WriteLine(num % 10);
}