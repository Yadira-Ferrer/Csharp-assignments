
Ejercicio1();
//Ejercicio2();

void Ejercicio1()
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("¿Cuenta con cupón de descuento? s/n: ");
    char cupon = Console.ReadLine().ToCharArray()[0];

    Console.WriteLine("\n> Precio de producto: Q.50");

    if (cupon == 's')
    {
        Console.WriteLine("> Precio al aplicar cupón de 15% de descuento: Q."+(50 * (1 - 0.15)));
    } else
    {
        Console.WriteLine("> No se ha aplicado ningún cupon.");
    }
}

void Ejercicio2()
{
    Console.WriteLine("LENGUAJES DE PROGRAMACIÓN\n");
    Console.WriteLine("\t1 C#");
    Console.WriteLine("\t2 Java");
    Console.WriteLine("\t3 C++");
    Console.WriteLine("\t4 JavaScript");
    Console.WriteLine("\t5 Python");

    Console.Write("\nSeleccione un lenguaje de programación ingrensando el número:  ");
    int opcion = int.Parse(Console.ReadLine());

    switch(opcion)
    {
        case 1:
            Console.WriteLine("\n[C# Hola Mundo]\n");
            Console.WriteLine("\tConsole.WriteLine(\"Hola Mundo\");");
            break;
        case 2:
            Console.WriteLine("\n[Java Hola Mundo]\n");
            Console.WriteLine("\tSystem.out.println(\"Hola Mundo\");");
            break;
        case 3:
            Console.WriteLine("\n[C++ Hola Mundo]\n");
            Console.WriteLine("\tstd::cout << \"Hola Mundo\";");
            break;
        case 4:
            Console.WriteLine("\n[JavaScript Hola Mundo]");
            Console.WriteLine("\tConsole.log(\"Hola Mundo\")");
            break;
        case 5:
            Console.WriteLine("\n[Python Hola Mundo]\n");
            Console.WriteLine("\tprint(\"Hola Mundo\")");
            break;
        default:
            Console.WriteLine("[!] Opción invalida...");
            break;
    }
}
