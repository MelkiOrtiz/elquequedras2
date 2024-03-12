////Ejercicios
//static void suma ()
//{ 
//// ejercicio 1
//int n1, n2, resultado = 0;
//Console.WriteLine("Ing. 1"); n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ing. 1");
//n2 = Convert.ToInt32(Console.ReadLine()); resultado = n1 + n2;
//  }
//static string nombre()
//{
//    // ejercicio 2
//    Console.WriteLine("Ingrese nombre: "); String nombre = Console.ReadLine();
//    return nombre;

//}

//static int edad()
//{
//    //ejercicio 3
//    Console.WriteLine("Ingrese su edad:");
//    int anionacimiento = Convert.ToInt32(Console.ReadLine()); int edad = 2024 - anionacimiento;
//    return edad;
//}

//int opc;
//do
//{
//    Console.WriteLine("1. Suma");
//    Console.WriteLine("2. nombre");
//    Console.WriteLine("3. edad");
//    Console.WriteLine("4. Salida");
//    opc = Convert.ToInt32(Console.ReadLine());
//    switch (opc)
//    {
//        case 1:
//            suma();
//            break;
//        case 2:
//            nombre();
//            break;
//        case 3:
//            edad();
//            break;
//    }
//}
//static int sumatoria(int num1, int num2, int num3)
//{
//    int resultado = 0;
//    resultado = num1 + num2 + num3;
//    return resultado;
//}
//string nombree = nombre();
//int promedio = sumatoria(20, 25, 40) / 3;
//Console.WriteLine ("Promedio =" + promedio);
//int edadd = edad();

//int numero;
//int mayor = int.MaxValue; // Se inicializamos el mayor con el valor mínimo posible :)
//int menor = int.MaxValue; // Se inicializamos el menor con el valor máximo posible :)
//Console.WriteLine("Ingrese valores positivos. Ingrese 0 para finalizar.");
//            do
//            {
//                Console.Write("Ingrese un número: ");
//                numero = int.Parse(Console.ReadLine());

//                if (numero != 0)
//                {
//                    // Verificar si el número ingresado es mayor al actual mayor
//                    if (numero > mayor)
//                    {
//                        mayor = numero;
//                    }

//                    // Verificar si el número ingresado es menor al actual menor
//                    if (numero < menor)
//                    {
//                        menor = numero;
//                    }
//                }
//            } while (numero != 0);

//// Mostrar el mayor y el menor número ingresado
//Console.WriteLine("El mayor número ingresado es: " + mayor);
//Console.WriteLine("El menor número ingresado es: " + menor);
//Console.ReadLine();


//Console.WriteLine("Piensa en un número");
//Console.WriteLine("Sigue las instrucciones y te adivinaré el número que has pensado.");
//// Paso 1: El adivinador le dice a la persona que anote un número.
//Console.Write("Escribe un número: ");
//int numero = int.Parse(Console.ReadLine());
//// Paso 2: El número se multiplica por 2.
//Console.WriteLine("Multiplica tu numero por 2");
//int resultado = numero * 2;
//// Paso 3: Se suma 8 al resultado.
//Console.WriteLine("Sumale 8 al resultado");
//resultado += 8;
//// Paso 4: Se multiplica el resultado por 5.
//Console.WriteLine("Multiplica por 5 el nuevo resultado");
//resultado *= 5;
//// Paso 5: El adivinador pide el resultado final.
//Console.Write("Dime el resultado final: ");
//int resultadoFinal = int.Parse(Console.ReadLine());
//// Paso 6: se elimina el último carácter convirtiendo el resultado a una cadena
//string resultadoString = resultadoFinal.ToString();
//resultadoString = resultadoString.Substring(0, resultadoString.Length - 1);
//// Paso 7: Se convierte el resultado final nuevamente a entero y se resta 4.
//resultadoFinal = int.Parse(resultadoString) - 4;
//// Paso 8: Se muestra el número adivinado.
//Console.WriteLine($"El número que pensaste es: {resultadoFinal}");
//Console.WriteLine("¡Gracias por jugar Tilin!");



//Console.WriteLine("Ingrese una frase:");
//string frase = Console.ReadLine();
//int contadorPalabras = 0;
//int contadorVocales = 0;
//int indice = 0;
//// Contar palabras con un bucle while
//while (indice < frase.Length)
//{
//    // Ignorar espacios en blanco al inicio de una palabra
//    while (indice < frase.Length && frase[indice] == ' ')
//    {
//        indice++;
//    }
//    // Si el índice llega al final de la frase, salir del bucle
//    if (indice == frase.Length)
//    {
//        break;
//    }
//    // Contar palabras mientras no haya un espacio en blanco
//    while (indice < frase.Length && frase[indice] != ' ')
//    {
//        contadorPalabras++;
//        // Contar vocales en la palabra actual
//        char caracter = char.ToLower(frase[indice]);
//        if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
//        {
//            contadorVocales++;
//        }
//        indice++;
//    }
//}
//Console.WriteLine($"Número de palabras en la frase: {contadorPalabras}");
//Console.WriteLine($"Número de vocales en la frase: {contadorVocales}");


        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        bool esPalindromo = true;

        // bucle for para comparar caracteres de la palabra
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                esPalindromo = false;
                break;
            }
        }

        // Mostrar mensaje :)
        if (esPalindromo)
        {
            Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
        }
   

