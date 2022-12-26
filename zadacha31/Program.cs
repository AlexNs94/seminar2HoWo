//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массив

Console.Clear();
int[] array = new int[12];
Random rand = new Random();
int SumPositive = 0;
int SumNigative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10); //{-9;10}
}
System.Console.WriteLine('[' + string.Join(',', array) + ']');

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        SumPositive+=array[i];
    }
    else
    {
        SumNigative+=array[i];
    }
}
System.Console.WriteLine($"Сумма положительных элементов = {SumPositive}, отрицательных {SumNigative}");