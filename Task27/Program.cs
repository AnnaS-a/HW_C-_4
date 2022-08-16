// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int num1 = Math.Abs(num);
    int sum = num1 % 10;

    while (num1 > 0)
    {
        num1 = num1 / 10;
        sum = sum + num1 % 10;
    }
    return sum;
}

int result = SumNum(number);
//string res = result == -1 ? "Необходимо вводить положительное число" : result.ToString();
Console.WriteLine($"Сумма цифр в чиселе {number} = {result}");
