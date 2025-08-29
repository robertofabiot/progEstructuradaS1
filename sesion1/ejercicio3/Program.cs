//Desarrolle un programa que calcule la distancia total recorrida en kilómetros por un ciclista en el malecón de San Juan del Sur, utilizando como entradas la velocidad promedio en kilómetros por hora y el tiempo recorrido, ambos proporcionados por el usuario.

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("======Calculadora de Distancia======");
Console.ResetColor();

// v = d / t => d = vt

Console.Write("Ingrese la velocidad promedio en kilómetros por hora: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("¿Cómo desea ingresar el tiempo de recorrido?");
Console.WriteLine("1. Horas (formato decimal)\n2. Horas y minutos\n3. Minutos");
int opcionTiempo = Convert.ToInt32(Console.ReadLine());
double tiempoHoras = 0;

if (opcionTiempo == 1)
{
    Console.Write("Ingrese el tiempo en horas (formato decimal): ");
    tiempoHoras = Convert.ToDouble(Console.ReadLine());
}
else if (opcionTiempo == 2)
{
    Console.Write("Ingrese las horas: ");
    int horas = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese los minutos: ");
    int minutos = Convert.ToInt32(Console.ReadLine());

    tiempoHoras = horas + (minutos / 60.0);
}
else if (opcionTiempo == 3)
{
    Console.Write("Ingrese los minutos: ");
    int minutos = Convert.ToInt32(Console.ReadLine());

    tiempoHoras = minutos / 60;
}
else
{
    Console.WriteLine("Número inválido. Ejecute nuevamente.");
}

double distancia = velocidad * tiempoHoras;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La distancia recorrida fue de {distancia:F2} kilómetros");
Console.ResetColor();