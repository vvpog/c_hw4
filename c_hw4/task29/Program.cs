// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void InputAndPrintArray () // ввод массива с клавиатуры
{
int N = 8;
Double[] array = new Double [N];

for (int i =0; i< N; i++)
    {
      Console.WriteLine($"Введите целое число - {i+1}-й элемент массива" );
      string name = Console.ReadLine();  
      array[i] = Convert.ToDouble(name); 
        
      Console.WriteLine(" ");
    }

    for (int i = 0; i < N-1; i++) {Console.Write($"{array [i]}, ");} 
    Console.Write($"{array [N-1]} ");

Console.WriteLine(" ");
return;
}
InputAndPrintArray ();