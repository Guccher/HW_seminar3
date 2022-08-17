// Console.Write("Input number: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// int Digit1 = Number / 10000;
// int Digit2 = Number / 1000 % 10;
// int Digit4 = Number / 10 % 10;
// int Digit5 = Number % 10;
// int Sum1 = Digit1 + Digit2;
// int Sum2 = Digit4 + Digit5;
// if (Sum1 == Sum2)
// {
// Console.WriteLine("Yes");
// }
// else
// {
// Console.WriteLine("No"); 
// }

// Console.Write("Input X1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Input Y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Input X2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Input Y2: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Input Z1: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Input Z2: ");
// int z2 = int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1 -x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
// Console.WriteLine($"d={d:f3}");

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
double result = 0;
while (count <= number)
{
  result = Math.Pow(count,3);
  count++;
  Console.WriteLine(""+result);
}
    


