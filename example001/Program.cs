// Найти кубы чисел от 1 до N

Console.WriteLine(" Введите число, до которого хотите получить расчет кубов чисел : ");
int N = int.Parse(Console.ReadLine());

for (int i=1; i<=N; i++)
{
    Console.WriteLine(i+"\t"+i*i*i);
}