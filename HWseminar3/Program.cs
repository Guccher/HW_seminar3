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

Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2 = int.Parse(Console.ReadLine());

double formula = Math.Sqrt(Math.Pow(x1 -x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
Console.WriteLine($"d={formula:f3}");