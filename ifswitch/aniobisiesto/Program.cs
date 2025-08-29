//Crear un programa que determine si un año es bisiesto usando if y operadores lógicos.

//Un año es bisiesto si es divisible por 4 pero no por 100, o si es divisible por 400.
//Los años de siglo (terminados en 00) no son bisiestos a menos que sean divisibles por 400.

Console.Write("Ingrese el año: ");
int anio = Convert.ToInt32(Console.ReadLine());

bool anio_siglo = anio % 100 == 0;

if (anio_siglo)
{
    if (anio % 400 == 0)
    {
        Console.WriteLine("Año bisiesto");
    }
    else
    {
        Console.WriteLine("No es año bisiesto");
    }
}
else if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
{
    Console.WriteLine("Año bisiesto");
}
else
{
    Console.WriteLine("No es año bisiesto");
}