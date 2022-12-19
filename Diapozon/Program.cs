//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.Clear();
int DataEntry (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return (number);
}

void FindQuartet(int ch)
{
    if ((ch > 4) || (ch <1)) Console.Write("Некоректный номер!");
    if (ch == 1)  Console.Write("x>0 , y>0");
    if (ch == 2)  Console.Write("x<0 , y>0");
    if (ch == 3)  Console.Write("x<0 , y<0");
    if (ch == 4)  Console.Write("x>0 , y<0");
    
}
int ch = DataEntry("Введите номер четверти = ");
FindQuartet(ch);