int num, suma = 0;
Console.Write("Dime un #: ");
string entrada = Console.ReadLine();
num = Convert.ToInt32(entrada);

while (num >= 0)
{
    suma += num;
    Console.Write("Dime un #: ");
    entrada = Console.ReadLine();
    num = Convert.ToInt32(entrada);
}

Console.WriteLine("La suma es: " + suma);