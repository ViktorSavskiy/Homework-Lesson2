Console.WriteLine("Введите цифру от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7)
{
  Console.WriteLine("Выходной");  
}
if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
   Console.WriteLine("Не выходной");   
}
if (num > 7 || num < 1)
{
  Console.WriteLine("Введите цифру от 1 до 7");  
}