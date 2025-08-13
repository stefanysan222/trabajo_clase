// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
decimal saldo = 500000m;
int opcion;

do
{
    Console.Clear();
    Console.WriteLine("=== CAJERO AUTOMÁTICO ===");
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Retirar dinero");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
        Console.ReadKey();
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"\nSu saldo actual es: {saldo:C}");
            break;

        case 2:
            Console.Write("\nIngrese el monto a retirar: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal retiro))
            {
                if (retiro <= 0)
                {
                    Console.WriteLine("El monto debe ser mayor que cero.");
                }
                else if (retiro > saldo)
                {
                    Console.WriteLine("Fondos insuficientes.");
                }
                else
                {
                    saldo -= retiro;
                    Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: {saldo:C}");
                }
            }
            else
            {
                Console.WriteLine("Monto inválido.");
            }
            break;

        case 3:
            Console.WriteLine("\nGracias por usar el cajero. ¡Hasta pronto!");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    if (opcion != 3)
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

} while (opcion != 3);