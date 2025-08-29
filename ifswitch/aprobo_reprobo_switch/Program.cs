Console.Write("Ingrese la calificación del estudiante: ");
double calificacion = Convert.ToDouble(Console.ReadLine());

switch (calificacion)
{
    case double n when (n >= 0 && n < 50):
        Console.WriteLine("Reprobó");
        break;

    case double n when (n >= 50 && n <= 69):
        Console.WriteLine("Recuperación");
        break;

    case double n when (n >= 70 && n <= 100):
        Console.WriteLine("Aprobó");
        break;

    default:
        Console.WriteLine("Valor inválido");
        break;
}
