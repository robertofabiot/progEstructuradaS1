Console.WriteLine("===CALCULADORA DE LECHE====");
Console.Write("Ingrese el volumen que produce una vaca en litros: ");
double volumen = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la cantidad de vacas ordeñadas: ");
int vacas = Convert.ToInt32(Console.ReadLine());

double lecheLitros = volumen * vacas;
double lecheBaldes = lecheLitros / 20;

Console.WriteLine($"La leche producida equivale a {lecheBaldes} baldes");