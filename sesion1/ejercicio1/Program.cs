//Desarrolle un programa que calcule el área total en manzanas de un terreno rectangular en una finca nicaragüense, donde el usuario ingresa la longitud y el ancho en varas (1 manzana = 1,428.8 varas²), utilizando una cantidad fija de 5 varas de ancho y la longitud como entrada.

Console.WriteLine("=====CALCULADORA DEL ÁREA EN MANZANAS=====");
Console.WriteLine("Se usa una longitud fija de 5 varas de ancho.");
int anchoVaras = 5;

Console.Write("Ingrese la longitud del terreno en varas: ");
double longitudVaras = Convert.ToDouble(Console.ReadLine());

double areaVaras = anchoVaras * longitudVaras;
double areaManzanas = areaVaras / 1428.8;

Console.WriteLine($"El área total del terreno es: {areaVaras} varas.");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Lo que equivale a {areaManzanas:F2} manzanas.");
Console.ResetColor();