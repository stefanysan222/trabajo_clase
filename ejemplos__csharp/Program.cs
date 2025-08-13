//* See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejemplo estructura condicionales");

/*Console.WriteLine("Estructura if");

//? sintaxis

sbyte EDAD_PARAMETRO = 18;
Console.Write("Ingresar su edad");
sbyte edad = sbyte.Parse(console.ReadLine());
if (edad >= EDAD_PARAMETRO)

{
    //vv
    console.WriteLine("Sos mayor de edad!");

} */

//? If simple
//! if compuesto
/*if (true)
{
// vv
}
{
    else
}

{
    // vf
} */

// IF SIMPLE
/*Console.WriteLine("=== IF SIMPLE ===");

int numero = 10;

if (numero > 0)
{
    Console.WriteLine("El número es positivo");
}


Console.WriteLine("\n=== IF COMPUESTO ===");

int edad = 16;

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}


// IF ANIDADO
//! IF ANIDADO

/* Console.Write("Estado civil: ");
string estado_civil = Console.ReadLine();

Console.Write("Edad: ");
sbyte edad = sbyte.Parse(Console.ReadLine());

Console.Write("Responsable (true/false): ");
bool responsable = bool.Parse(Console.ReadLine());

Console.Write("Hijos: ");
string hijos = Console.ReadLine();

// Parámetros de comparación
string PARAMETRO_ESTADO_CIVIL = "Soltero";
sbyte PARAMETRO_EDAD = 20;
bool PARAMETRO_RESPONSABLE = true;
string PARAMETRO_HIJOS = "Sin hijos"; */

// Condicional anidado
/* if (estado_civil == PARAMETRO_ESTADO_CIVIL)
{
    if (edad >= PARAMETRO_EDAD)
    {
        if (responsable == PARAMETRO_RESPONSABLE)
        {
            if (hijos != PARAMETRO_HIJOS)
            {
                Console.WriteLine("Hombre ideal.");
            }
            else
            {
                Console.WriteLine("Hombre ideal. Porque no tiene hijos.");
            }
        }
        else
        {
            Console.WriteLine("Hombre no ideal. Por irresponsable.");
        }
    }
    else
    {
        Console.WriteLine("Hombre no ideal. Es muy joven.");
    }
}
else
{
    Console.WriteLine("Hombre no ideal. No es soltero.");
} */


//? USO DE OPERADORES LOGICOS O &&
// &&= lampera
/*if (estado_civil == PARAMETRO_ESTADO_CIVIL &&
edad>= PARAMETRO_EDAD && responsable == PARAMETRO_RESPONSABLE &&
hijos != PARAMETRO_HIJOS )
{
 Console.WriteLine("Hombre ideal");
}
else
{
 Console.WriteLine("Hombre no ideal");
}
*/
// Tipo de producto: Celular, Televisor, Computadora
Console.WriteLine("Tipo de producto:");
string tipo_producto = Console.ReadLine()?.ToLower(); // El ? evita el warning de posible null

string PARAMETRO_CELULAR = "celular";
string PARAMETRO_TELEVISOR = "televisor";
string PARAMETRO_COMPUTADORA = "computadora";

int precio = 0;

if (tipo_producto == PARAMETRO_CELULAR)
{
    precio = 600000;
}
else if (tipo_producto == PARAMETRO_TELEVISOR)
{
    precio = 2100000;
}
else if (tipo_producto == PARAMETRO_COMPUTADORA)
{
    precio = 5500000;
}
else
{
    Console.WriteLine("Tipo de producto no válido.");
}

Console.WriteLine($"El precio del producto {tipo_producto} es: {precio}");




// USO DE OPERADORES LÓGICOS (||)
if (tipo_producto == PARAMETRO_CELULAR ||
    tipo_producto == PARAMETRO_TELEVISOR ||
    tipo_producto == PARAMETRO_COMPUTADORA)
{
    precio = 100000;
    Console.WriteLine("Producto válido. Nuevo precio especial: " + precio);
}
else
{
    Console.WriteLine("Producto no válido.");
}

// EJERCICIO C#
//Se debe crear un Menú de opciones

//Fecha actual

//mostrar mi nombre

//mensaje motivador

//salir

bool salir = false;
while (!salir)
{
    Console.Clear();
    Console.WriteLine("===== MENÚ DE OPCIONES =====");
    Console.WriteLine("1. Mostrar fecha actual");
    Console.WriteLine("2. Mostrar mi nombre");
    Console.WriteLine("3. Mostrar mensaje motivador");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine() ?? string.Empty;

    switch (opcion)
    {
        case "1":
            Console.WriteLine($"Fecha actual: {DateTime.Now}");
            break;
        case "2":
            Console.WriteLine("Mi nombre es: Isa Romero");
            break;
        case "3":
            Console.WriteLine("¡Nunca te rindas, cada día es una nueva oportunidad!");
            break;
        case "4":
            Console.WriteLine("¡No vuelvas!");
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
    if (!salir)
    {
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}


// SEGUNDO EJERCICIO
// aplicacion tipo consola que determine los niveles de valgo de rodilla, 
// que tenga rangos, 5- 10 nivel a 11- 15 nivel b (masomenos 4 rangos )


// SEGUNDO EJERCICIO
// Aplicación tipo consola que determine los niveles de valgo de rodilla
// con 4 rangos definidos

Console.WriteLine("=== DETECCIÓN DE NIVEL DE VALGO DE RODILLA ===");

Console.Write("Ingrese el valor de separación entre rodillas (en cm): ");
int valor = int.Parse(Console.ReadLine());

// Evaluación de rangos
if (valor >= 0 && valor <= 5)
{
    Console.WriteLine("Nivel A: Valgo leve");
}
else if (valor >= 6 && valor <= 10)
{
    Console.WriteLine("Nivel B: Valgo moderado");
}
else if (valor >= 11 && valor <= 15)
{
    Console.WriteLine("Nivel C: Valgo severo");
}
else if (valor > 15)
{
    Console.WriteLine("Nivel D: Valgo muy severo");
}
else
{
    Console.WriteLine("Valor inválido. Ingrese un número positivo.");
}


/*
// USO DE OPERADORES LOGICOS O ||
if (estado_civil == PARAMETRO_ESTADO_CIVIL ||
edad>= PARAMETRO_EDAD || responsable == PARAMETRO_RESPONSABLE ||
hijos != PARAMETRO_HIJOS )
{
 Console.WriteLine("Hombre ideal");
}
else
{
 Console.WriteLine("Hombre no ideal");
} */

