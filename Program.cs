double a, b ,c, delta, x1, x2;

Console.Write("(a):");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("(b):");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c):");
c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(b,2) -4 * a *c;
if (a == 0)
{
    
    Console.ForegroundColor=  ConsoleColor.Yellow;
    Console.WriteLine("Não é uma equação de segundo grau!");
        Console.ResetColor();
}
else if (delta < 0)
{
    Console.ForegroundColor=  ConsoleColor.DarkRed;
    Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais!");
    Console.ResetColor();
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    
    
    Console.WriteLine($"x1 ={x1:N2} e x2 ={x2:N2}");
}

