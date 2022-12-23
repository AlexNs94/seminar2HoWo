

Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] FillArray(int[] array)
{
    int Length = array.Length;
    int index = 0;
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;

}
void PrintArray(int[] Fill)
{
    int count = Fill.Length;
    int i = 0;

    for (i = 1; i < count; i++)
    {
        Console.Write(Fill[i] + " ");
        //position++;
    }
}
int number = DataEntry("Введите размер :");
int[] array = new int[number];
array = FillArray(array);
PrintArray(array);