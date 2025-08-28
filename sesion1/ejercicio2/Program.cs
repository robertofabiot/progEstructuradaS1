//Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada, donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada, asumiendo una distancia fija de 40 kilómetros.

Console.WriteLine("=====CALCULADORA DEL TIEMPO DE VIAJE EN BUS=====");
int distancia = 40;

// v = d / t  => t = d / v

Console.Write("Ingrese la velocidad promedio del bus en km/h: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

double tiempoHoras = distancia / velocidad;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"El tiempo total del viaje es: {tiempoHoras:F2} horas.");
Console.ResetColor();