// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число дня недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 5)
{
    System.Console.WriteLine("Да, этот день выходной!");
}
else
{
    System.Console.WriteLine("Увы, но это рабочий день!");
}