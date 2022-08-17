// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ExtentNum(int num1, int num2)
    {
        int res = num1;
        for (int count = 2; num2 >= 2 && count <= num2; count++)
        {
            res = res * num1;
        }
        return res;
    }
while (number2 > 0)
{
        int result = ExtentNum(number1, number2);
    Console.WriteLine($"Число {number1} в степени {number2} равно {result}");
    break;
}
if (number2 <= 0) Console.WriteLine("Второе число введено некорректно");

