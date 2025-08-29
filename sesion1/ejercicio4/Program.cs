Console.WriteLine("¡Vamos a calcular el volumen del tanque de agua!");

Console.Write("Ingrese la longitud del tanque: ");
double longitud = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el ancho del tanque: ");
double ancho = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura del tanque: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volumen = longitud * ancho * altura;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"El volumen del tanque es {volumen}");
Console.ResetColor();