static void Menu()
{
    int opcion = 0;
    do
    {
        Console.WriteLine("Menú:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Datos");
        Console.WriteLine("3. Nacimiento");
        Console.WriteLine("4. Adivinare tu numero");
        Console.WriteLine("5. Palidromos");
        Console.WriteLine("6. Contador de Palabras");
        Console.WriteLine("7. Salida");
        Console.Write("Ingrese una opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Suma();
                break;
            case 2:
                string nombre = Saludo();
                int promedio = Sumatoria();
                int edad = CalculoEdad();
                Console.WriteLine($"{nombre}, tienes {edad} años y tu promedio es {promedio}");
                break;
            case 3:
                CalculoEdad();
                break;
            case 4:
                int adivina = harrypopoter();
                break;
            case 5:
                string pali = palidromo();
                break;
            case 6:
                string contadorpal = contador();
                break;
            case 7:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                break;
        }

        Console.WriteLine();
    } while (opcion != 7);


}

static void Suma()
{
    Console.WriteLine("Ingrese el primer número:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int resultado = num1 + num2;
    Console.WriteLine($"El resultado de la suma es: {resultado}");
}

static int Sumatoria()
{
    Console.WriteLine("Ingrese su primera nota por favor...");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su segunda nota por favor...");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su tercera nota por favor...");
    int num3 = int.Parse(Console.ReadLine());
    int resultado = num1 + num2 + num3 / 3;
    return resultado;
}

static string Saludo()
{
    Console.WriteLine("Ingrese su nombre:");
    return Console.ReadLine();
}

static int CalculoEdad()
{
    Console.WriteLine("Ingrese su año de nacimiento:");
    int añoNacimiento = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - añoNacimiento;
    Console.WriteLine($"Usted tiene {edad} años.");
    return edad;
}

static int harrypopoter()
{
    Console.WriteLine("Piense en un numero del 1 al 100 :D");
    Console.Write("Presiona enter cuando lo hayas hecho... ");
    Console.ReadLine();
    Console.WriteLine("Ahora multiplique este numero por 2");
    Console.Write("Presiona enter cuando lo hayas hecho... ");
    Console.ReadLine();
    Console.WriteLine("Ahora sumele 8");
    Console.Write("Presiona enter cuando lo hayas hecho... ");
    Console.ReadLine();
    Console.WriteLine("Ahora multipliquelo por 5");
    Console.Write("Presiona enter cuando lo hayas hecho... ");
    Console.ReadLine();
    Console.WriteLine("Digite su resultado:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int resultado = (num1 / 10) - 4; Console.WriteLine($"El numero que usted esta pensando es: {resultado}");
    return 0;
}

static string contador()
{
    Console.WriteLine("Digite una frase por favor:");
    string frase = Console.ReadLine();
    int Numpalabras = 0;
    int Numvocales = 0;
    int i = 0;
    while (i < frase.Length)
    {
        if (frase[i] != ' ' && (i == 0 || frase[i - 1] == ' '))
        {
            Numpalabras++;
        }
        char letra = Char.ToLower(frase[i]);
        if (char.IsLetter(frase[i]) && (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'))
        {
            Numvocales++;
        }
        i++;
    }
    Console.WriteLine($"Numero de palabras: {Numpalabras}");
    Console.WriteLine($"Numero de vocales: {Numvocales}");
    return Console.ReadLine();
}


static string palidromo()
{
    Console.WriteLine("Ingrese una palabra:");
    string palabra = Console.ReadLine();

    bool esPalindromo = EsPalindromo(palabra);

    if (esPalindromo)
    {
        Console.WriteLine("La palabra ingresada SI es un palíndromo.");
    }
    else
    {
        Console.WriteLine("La palabra ingresada NO es un palíndromo.");
    }
    return Console.ReadLine();
}

static bool EsPalindromo(string palabra)
{
    int longitud = palabra.Length;
    for (int i = 0; i < longitud / 2; i++)
    {
        if (palabra[i] != palabra[longitud - i - 1])
        {
            return false;
        }
    }
    return true;
}

Menu();
