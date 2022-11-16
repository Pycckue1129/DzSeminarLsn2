// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int rezervNum = num;
int i = 0;
int i2 = 0;
while (num != 0)
{
    num = num / 10;
    i++;
}

if (i > 2)
{
    while (i2 != i - 3)
    {
      rezervNum = rezervNum / 10;
       i2++;
    }
    Console.WriteLine(rezervNum % 10);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}

