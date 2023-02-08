// Напишите программу, которая принимает на вход число А
// и выдает сумму чисел от 1 до А.

Console.Clear();
Console.Write ("Введите число: ");
int n = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Сумма чисел от 1 до {n} равна {GetSum (n)}");

int GetSum (int limit) {
int sum = 0;
for (int i = 1; i <= limit; i++)
sum += i;
return sum;
}