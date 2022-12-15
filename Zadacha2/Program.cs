Console.Clear();

Console.WriteLine(" Введите число ");

int number = int.Parse(Console.ReadLine()); 



if (number < 0) 
    
    Console.WriteLine(" программа не работает с отрицательными числами ");

else 
{
    if (number < 100 && number >= 0)
     
        Console.WriteLine($" в числе  {number} нет третей цифры ");
      
    else
       {
            while (number > 1000)
                { 
                    number = number / 10;
                }
                int ostatok = number % 10;
        
                Console.WriteLine($" в числе  {number} третья цифра {ostatok}");
        };
};
