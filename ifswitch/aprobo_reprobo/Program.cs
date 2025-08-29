// Evaluar la calificación de un estudiante y mostrar si aprobó (≥70), recuperación (50–69) o reprobó (<50) con if.

Console.Write("Ingrese la calificación del estudiante: ");
double calificacion = Convert.ToDouble(Console.ReadLine());

if (calificacion >= 70 && calificacion <=100)
{
    Console.WriteLine("Aprobó");
}
else if (calificacion >= 50 && calificacion <= 69)
{
    Console.WriteLine("Recuperación");
}
else if (calificacion < 50 && calificacion >= 0)
{
    Console.WriteLine("Reprobó");
}
else
{
    Console.WriteLine("Valor inválido");
}