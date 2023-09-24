// Задача 2. напишите программу, которая на вход
// принимает два числа и выдаёт, какое число больше, а 
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> int.MaxValue = -3

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32 (Console.Read());
 
 Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b);
{
    Console.WriteLine ("Большее число: + a + , меньшее число + b");
}
else
{
    Console.WriteLine ($"большее число, меньшее число");
}
