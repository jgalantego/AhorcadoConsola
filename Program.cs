using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
        const int MAX_INTENTOS = 5;
        // Array de palabras
        string[] arrayPalabras = { "ordenador", "tecnologias", "moviles", "practicas" };
        bool quiereJugar = true;

        // Mensaje de bienvenida
        Console.Clear();
        Console.WriteLine("¡Bienvenido al juego del ahorcado!");
        Console.WriteLine("Tienes " + MAX_INTENTOS + " intentos para adivinar la palabra.");
        Console.WriteLine("Pulsa una tecla para comenzar a jugar...");
        Console.ReadKey();

        do
        {
            // Seleccionar una palabra aleatoria
            Random rand = new Random();
            int numPalabra = rand.Next(arrayPalabras.Length);
            string palabra = arrayPalabras[numPalabra].ToUpper();

            // Inicializar variables
            char[] palabraAdivinada = new string('_', palabra.Length).ToCharArray();
            int intentosFallidos = 0;
            bool palabraCompleta = false;
            List<char> letrasUsadas = new List<char>();

            // Bucle principal del juego
            while (intentosFallidos < MAX_INTENTOS && !palabraCompleta)
            {
                Console.Clear();
                Console.WriteLine("Palabra a adivinar: " + new string(palabraAdivinada));
                Console.WriteLine("Intentos fallidos: " + intentosFallidos + " de " + MAX_INTENTOS);
                Console.WriteLine("Letras usadas: " + string.Join(", ", letrasUsadas));
                Console.Write(" - Introduce una letra: ");

                string entrada = Console.ReadLine()!.ToUpper();

                if (string.IsNullOrWhiteSpace(entrada) || entrada.Length != 1)
                {
                    Console.WriteLine("Por favor, introduce solo una letra válida.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                char letra = entrada[0];
                Console.WriteLine("Letra introducida: " + letra);

                if (letrasUsadas.Contains(letra))
                {
                    Console.WriteLine("Ya has usado esa letra. Intenta con otra.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    letrasUsadas.Add(letra);
                }

                if (palabra.Contains(letra))
                {
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabra[i] == letra)
                        {
                            palabraAdivinada[i] = letra;
                        }
                    }
                }
                else
                {
                    intentosFallidos++;
                }

                palabraCompleta = !new string(palabraAdivinada).Contains('_');
            }

            Console.Clear();
            if (palabraCompleta)
            {
                Console.WriteLine("¡Felicidades! Has adivinado la palabra: " + palabra);
            }
            else
            {
                Console.WriteLine("Has perdido. La palabra era: " + palabra);
            }
            Console.WriteLine("");
            Console.Write("¿Quieres jugar de nuevo? (S/N): ");
            string respuesta = Console.ReadLine()!.ToUpper();
            if (respuesta != "S")
            {
                quiereJugar = false;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                Console.WriteLine("");
            }
        } while (quiereJugar);
    }
}
