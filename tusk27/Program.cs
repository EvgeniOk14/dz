Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = n.ToString();
int Sum = 0;
for (int i = 0; i < s.Length; i++)
{ 
   int d = Convert.ToInt32(s[i].ToString());
   Sum += d;
}
Console.WriteLine("Sum = " + Sum); 
