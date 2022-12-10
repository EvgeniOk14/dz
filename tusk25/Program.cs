Console.Clear();
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;;
 for (int i = 2; i <= B; i++)
 {
    result = result * A;
 }
Console.WriteLine(result);
