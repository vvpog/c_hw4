// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

void SummOst()
{
Console.WriteLine("Введите число");
string N = Console.ReadLine();
int n = Convert.ToInt32(N);
int summ = 0;

if (n<0) {n= -1 * n;}

while (n > 0)
 {
    summ = n%10 + summ;
    n=n/10;
 }
Console.WriteLine($"В числе {N} cумма цифр равна {summ}");
return;
}
SummOst();