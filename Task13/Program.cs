
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num > 99)
{
int a = num/100;
int b = a%10;
 Console.WriteLine(b);   
}
else
{
    Console.WriteLine("Третьей цифры нет"); 
}