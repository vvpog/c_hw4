// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

 void PowerCalc()
{
Console.WriteLine("Введите число, которое будем возводить в степень");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень этого числа:");
int b = Convert.ToInt32(Console.ReadLine());
float pow = 1; int B = Math.Abs(b);

if (b >= 0) 
    {   while (B > 0)
        { pow = pow * a; B = B - 1 ; }        
    }
else 
    {   while (B > 0)
        { pow = pow / a; B = B - 1 ; }    
    }
 Console.WriteLine($" Число {a} в степени {b} равно {pow}");
 return;
}
 PowerCalc();

