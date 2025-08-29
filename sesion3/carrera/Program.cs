Console.WriteLine("Ingrese un número según la carrera que estudia: ");
int carrera = Convert.ToInt32(Console.ReadLine());

switch (carrera)
{
    case 1:
        Console.WriteLine("El usuario estudia medicina.");
        break;
    case 2:
        Console.WriteLine("El usuario estudia sistemas.");
        break;
    case 3:
        Console.WriteLine("El usuario dejó de estudiar.");
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}