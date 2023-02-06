// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");

int Number = int.Parse(Console.ReadLine());
int sum = 0;

for (int i=Number; i>0; i= i/10)
{
    sum = sum + i % 10;
}
Console.WriteLine("Сумма цифр в числе равна : " +sum);
