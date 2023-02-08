// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число до которого будет вычисляться произведения чисел: ");

int N = int.Parse(Console.ReadLine());
int result = 1;

for (int i=1; i<=N; i++) result = result*i;
 {
    Console.Write("Произведение чисел равно: " + result);
 }