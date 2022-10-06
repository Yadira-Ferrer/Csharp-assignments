// See https://aka.ms/new-console-template for more information

void Ejercicio1()
{
    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine();
    
    Console.Write("Ingrese su edad: ");
    int edad = int.Parse(Console.ReadLine());
    
    Console.Write("¿Sabe programar? s/n: ");
    string strSabeProgramar = Console.ReadLine();
    bool sabeProgramar = false;
    if ( strSabeProgramar == "s" )
    {
        sabeProgramar = true;
    }
    
    Console.Write("Genero: f/m: ");
    char genero = Console.ReadLine().ToCharArray()[0];

    Console.Write("Estatura: ");
    double estatura = double.Parse(Console.ReadLine());

    Console.WriteLine("\n======= DATOS INGRESADOS ========");
    Console.WriteLine("Nombre: \t"+nombre);
    Console.WriteLine("Edad: \t\t" + edad);
    Console.WriteLine("Sabe programar: " + sabeProgramar);
    Console.WriteLine("Genero: \t" + genero);
    Console.WriteLine("Estatura: \t" + estatura);
    Console.WriteLine("=================================");
}

void Ejercicio2 ()
{
    int coche_cantidad_puertas = 5;
    int coche_cantidad_ruedas = 4;
    string coche_marca = "Volvo";
    bool coche_itv_vigente = true;
 
    double mesa_peso = 24.18;
    double mesa_largo = 2;
    string mesa_material = "madera";
    string mesa_color = "cobre";

    Console.WriteLine("\n=========== COCHE ============");
    Console.WriteLine("Cantidad de puertas: \t" + coche_cantidad_puertas);
    Console.WriteLine("Cantidad de ruedas: \t" + coche_cantidad_ruedas);
    Console.WriteLine("Marca: \t\t\t" + coche_marca);
    Console.WriteLine("ITV Vigente: \t\t" + coche_itv_vigente);
    Console.WriteLine("==============================");

    Console.WriteLine("\n=========== MESA =========");
    Console.WriteLine("Peso: \t\t" + mesa_peso);
    Console.WriteLine("Largo: \t\t" + mesa_largo);
    Console.WriteLine("Material: \t" + mesa_material);
    Console.WriteLine("Color: \t\t" + mesa_color);
    Console.WriteLine("==========================");

}

void Ejercicio3()
{
    Console.Write("Ingrese un número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Ingrese un caracter: ");
    int caracter = Console.ReadLine().ToCharArray()[0];


    Console.WriteLine("\nResultados:");
    if (numero >= 18)
    {
        Console.WriteLine("El número ingresado es mayor a 18");
    } 

    if (caracter == 'a')
    {
        Console.WriteLine("El caracter ingresado es 'a'");
    }

    if ( numero >= 18 && caracter == 'a')
    {
        Console.WriteLine("El numero es mayor a 18 y el caracter ingresado es 'a'");
    }

    if (numero >= 18 || caracter == 'a')
    {
        Console.WriteLine("El numero es mayor a 18 o el caracter ingresado es 'a'");
    }

}

// Ejercicio1();
// Ejercicio2();
// Ejercicio3();