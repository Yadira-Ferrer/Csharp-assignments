void Ejercicio1 ()
{
    Console.Write("Ingresa un numero: ");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine("========== TABLA DE MULTIPLICAR DEL '"+numero+ "' ==========");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(numero+" x "+i+" = " +(i*numero));
    }
}

void Ejercicio2 ()
{
    int numero = 0;
    int contadorPositivos = 0;
    int contadorNegativos = 0;

    do
    {
        Console.Write("Ingresa un numero (0 = salir): ");
        numero = int.Parse(Console.ReadLine());

        if (numero == 0)
        {
            break;
        }
        else if (numero > 0)
        {
            contadorPositivos++;
        }
        else
        {
            contadorNegativos++;
        }

        Console.WriteLine("Numeros positivos = " + contadorPositivos + " | Numeros negativos = " + contadorNegativos+"\n");
    } while (numero != 0);
}

void Ejercicio3()
{
    int alto = 0;
    int ancho = 0;
    int cantidad = 1;
    bool relleno = false;

    Console.Write("Ancho del rectangulo: ");
    ancho = int.Parse(Console.ReadLine());

    Console.Write("Alto del rectangulo: ");
    alto = int.Parse(Console.ReadLine());

    Console.Write("¿Relleno? s/n: ");
    char char_relleno = Console.ReadLine().ToCharArray()[0];
    if(char_relleno == 's') { relleno = true; } else { relleno = false; }

    Console.Write("Cantidad de rectangulos: ");
    cantidad = int.Parse(Console.ReadLine());

    if (relleno)
    {
        Console.Write("\nRECTANGULO RELLENO:\n\n");

        for (int i = 0; i < alto; i++)
        {
            for (int c = 0; c < cantidad; c++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\t");
            }
            Console.Write("\n");
        }
    } else
    {
        Console.Write("\nRECTANGULO SIN RELLENO:\n\n");
        for (int i = 0; i < alto; i++)
        {
            for (int c = 0; c < cantidad; c++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (i == 0 || i == (alto - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if ((i > 0 && j == 0) || i > 0 && j == (ancho - 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\t");
            }
            Console.Write("\n");
        }
    }      
}

//Ejercicio1();
//Ejercicio2();
Ejercicio3();