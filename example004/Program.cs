// Показать кубы чисел, заканчивающиеся на четную цифру

int [] array = new int[7];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,20);
}
for (int i = 0; i < array.Length; i++)
Console.WriteLine ($" {array[i]} \t");

for (int i = 0; i < array.Length; i++)
{
    int number = array[i];
    if ((array[i] % 2 == 0))
    {
        double cube = Math.Pow(array[i],3);
        Console.WriteLine("Куб числа " + number + " равен " + cube + " и заканчивается на четную цифру");
}
}