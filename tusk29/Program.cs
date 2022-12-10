Console.Clear();
Console.Write("Задайте размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом { i }  {":"} ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}   
  Console.WriteLine("\n Вывод массива: \n");
  Console.Write($"[{string.Join(", ", array)}]");

