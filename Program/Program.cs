// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a, b, max;
Console.WriteLine("Введите два числа:"); //Просим пользователя ввести два числа для сравнения
a = int.Parse(Console.ReadLine()!);
b = int.Parse(Console.ReadLine()!);
if (a <= b) {
    max=b;
} 
else {
    max=a;
}
Console.WriteLine("Максимальное число: " + max);