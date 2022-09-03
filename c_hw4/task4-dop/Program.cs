// Массив размерности N вводится с клавиатуры и сортируется от большего к меньшему

Console.WriteLine("введите число элементов в массиве, целое положительное число " );
int N = Convert.ToInt32(Console.ReadLine());
Double[] array = new Double [N];
for (int i=0; i<N; i++)
 {
    array[i]=new Random().Next(-100, 100); 
    Console.Write($"{array[i]} ");
 };
 Console.WriteLine(" ");

void InputAndPrintArray (Double[] array) // ввод массива с клавиатуры
{
    for (int i =0; i< N; i++)
    {
      Console.WriteLine($"Введите целое число - {i+1}-й элемент массива" );
       Console.WriteLine("Для окончания ввода нажмите: k , " + 
       "оставшиеся элементы заполнятся случайными числами," + 
       " но ввод почему-то не прервется ;(" );

      string name = Console.ReadLine();  
      switch (name)
        {
        case "k":
        Console.WriteLine("Ввод числа с клавиатуры не произведен");
        Console.Write($"Результат: случайное число {array[i]} ");
        break;

        default:
        array[i] = Convert.ToDouble(name); 
        break;
        }
      Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
    Console.WriteLine($"В результате получился массив:");
    for (int i = 0; i < N-1; i++) {Console.Write($"{array [i]}, ");} 
    Console.Write($"{array [N-1]} ");

Console.WriteLine(" ");
}

void SelectionSort(Double[] array) // сортировка по убыванию
{
for (int i = 0; i < array.Length-1 ; i++)
    {
    int maxPosition = i;

for (int j = i + 1; j < array.Length; j++)
{
 if(array[j] > array[maxPosition])  maxPosition = j;
}

    Double temporary = array [i];
    array[i] = array[maxPosition];
    array[maxPosition] = temporary;
    }

for (int i = 0; i < array.Length ; i++)
    { Console.Write("  " + array[i]);};

}

InputAndPrintArray(array);
SelectionSort(array);