int diaSemana = 0;
Console.Write("Ingrese el número de día: ");
diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.Write("Lunes");
        break;
    case 2:
        Console.Write("Martes");
        break;
    case 3:
        Console.Write("Miércoles");
        break;
    case 4:
        Console.Write("Jueves");
        break;
    case 5:
        Console.Write("Viernes");
        break;
    case 6:
        Console.Write("Sábado");
        break;
    case 7:
        Console.Write("Domingo");
        break;
    default:
        Console.Write("Ingrese un día válido.");
        break;
}