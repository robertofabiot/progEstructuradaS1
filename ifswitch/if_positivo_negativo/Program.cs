//Determinar si un número ingresado es positivo, negativo o cero usando if.

Console.Write("Ingrese un número: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("El número es positivo");
}
else if (num < 0)
{
    Console.WriteLine("El número es negativo");
}
else if (num == 0)
{
    Console.WriteLine("El número es cero");
}
else
{
    Console.WriteLine("Valor inválido");
}