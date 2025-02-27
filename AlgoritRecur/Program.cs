using System;
using System.Diagnostics;
using System.Numerics; // Importar el espacio de nombres para BigInteger

class Program
{
    static void Main(string[] args)
    {
        bool salir = false; // Bandera para controlar el bucle principal

        while (!salir)
        {
            Console.WriteLine("===== Algoritmos Recursivos =====");
            Console.WriteLine("1. Factorial de un número");
            Console.WriteLine("2. Cálculo de un exponente");
            Console.WriteLine("3. Sumar los elementos de un arreglo");
            Console.WriteLine("4. Secuencia de Fibonacci");
            Console.WriteLine("5. Búsqueda binaria");
            Console.WriteLine("6. Algoritmo de la Torre de Hanoi");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            // Validación de entrada del usuario
            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                continue; // Repetir el bucle si la entrada es inválida
            }

            // Control del flujo según la opción elegida
            switch (opcion)
            {
                case 1:
                    EjecutarFactorial();
                    break;
                case 2:
                    EjecutarExponente();
                    break;
                case 3:
                    EjecutarSumaArreglo();
                    break;
                case 4:
                    EjecutarFibonacci();
                    break;
                case 5:
                    EjecutarBusquedaBinaria();
                    break;
                case 6:
                    EjecutarHanoi();
                    break;
                case 7:
                    salir = true; // Salir del bucle principal
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    // Factorial de un número usando BigInteger
    static BigInteger Factorial(int n, ref int operaciones)
    {
        operaciones++; // Incrementar el contador de operaciones
        if (n < 0) throw new ArgumentException("El número debe ser no negativo."); // Validar que n no sea negativo

        // Caso base: el factorial de 0 es 1
        // Esto detiene la recursión. Sin este caso base, la función llamaría a sí misma indefinidamente.
        if (n == 0) return 1;

        // Llamada recursiva: el factorial de n es n * (n-1)!
        return n * Factorial(n - 1, ref operaciones);
    }

    // Método para ejecutar el cálculo del factorial
    static void EjecutarFactorial()
    {
        Console.Write("Ingrese un número para calcular el factorial: ");

        // Validación de entrada del usuario
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            return; // Salir de la función si la entrada es inválida
        }

        int operaciones = 0; // Contador de operaciones
        var cronometro = new Stopwatch(); // Inicializar el cronómetro

        try
        {
            cronometro.Start(); // Iniciar el cronómetro
            BigInteger resultado = Factorial(n, ref operaciones); // Calcular el factorial
            cronometro.Stop(); // Detener el cronómetro
            Console.WriteLine($"Factorial de {n} es: {resultado}");
        }
        catch (Exception e)
        {
            cronometro.Stop(); // Detener el cronómetro si ocurre una excepción
            Console.WriteLine(e.Message); // Mostrar mensaje de error en caso de excepción
        }

        Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds:F4} ms");
        Console.WriteLine($"Número de operaciones: {operaciones}");
    }

    // Cálculo de un exponente
    static BigInteger Exponente(int baseNum, int exp, ref int operaciones)
    {
        operaciones++; // Incrementar el contador de operaciones
        if (exp < 0) throw new ArgumentException("El exponente debe ser no negativo."); // Validar que el exponente no sea negativo

        // Caso base: cualquier número elevado a 0 es 1
        // Esto detiene la recursión.
        if (exp == 0) return 1;

        // Llamada recursiva: baseNum^exp = baseNum * baseNum^(exp - 1)
        return baseNum * Exponente(baseNum, exp - 1, ref operaciones);
    }

    // Método para ejecutar el cálculo de un exponente
    static void EjecutarExponente()
    {
        Console.Write("Ingrese la base: ");
        if (!int.TryParse(Console.ReadLine(), out int baseNum))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            return;
        }

        Console.Write("Ingrese el exponente: ");
        if (!int.TryParse(Console.ReadLine(), out int exp))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            return;
        }

        int operaciones = 0;
        var cronometro = new Stopwatch();

        try
        {
            cronometro.Start(); // Iniciar el cronómetro
            BigInteger resultado = Exponente(baseNum, exp, ref operaciones); // Calcular el exponente
            cronometro.Stop(); // Detener el cronómetro
            Console.WriteLine($"{baseNum} elevado a {exp} es: {resultado}");
        }
        catch (Exception e)
        {
            cronometro.Stop(); // Detener el cronómetro si ocurre una excepción
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds:F4} ms");
        Console.WriteLine($"Número de operaciones: {operaciones}");
    }

    // Sumar los elementos de un arreglo
    static int SumarArreglo(int[] arreglo, int indice, ref int operaciones)
    {
        operaciones++; // Incrementar el contador de operaciones

        // Caso base: si el índice es negativo, devolver 0
        // Esto significa que hemos recorrido todo el arreglo.
        if (indice < 0) return 0;

        // Llamada recursiva: sumar el elemento actual y la suma del resto del arreglo
        return arreglo[indice] + SumarArreglo(arreglo, indice - 1, ref operaciones);
    }

    // Método para ejecutar la suma de los elementos de un arreglo
    static void EjecutarSumaArreglo()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        if (!int.TryParse(Console.ReadLine(), out int tamaño) || tamaño < 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo.");
            return;
        }

        int[] arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out arreglo[i]))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                return;
            }
        }

        int operaciones = 0;
        var cronometro = new Stopwatch();
        cronometro.Start(); // Iniciar el cronómetro
        int resultado = SumarArreglo(arreglo, arreglo.Length - 1, ref operaciones);
        cronometro.Stop(); // Detener el cronómetro

        Console.WriteLine($"La suma de los elementos del arreglo es: {resultado}");
        Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds:F4} ms");
        Console.WriteLine($"Número de operaciones: {operaciones}");
    }

    // Secuencia de Fibonacci
    static BigInteger Fibonacci(int n, ref int operaciones)
    {
        operaciones++; // Incrementar el contador de operaciones
        if (n < 0) throw new ArgumentException("El número debe ser no negativo."); // Validar que n no sea negativo

        // Casos base:
        // Fibonacci de 0 es 0
        // Fibonacci de 1 es 1
        // Estos casos detienen la recursión. Sin ellos, la función llamaría a sí misma indefinidamente.
        if (n == 0) return 0;
        if (n == 1) return 1;

        // Llamada recursiva: suma de los dos números anteriores en la secuencia
        return Fibonacci(n - 1, ref operaciones) + Fibonacci(n - 2, ref operaciones);
    }

    // Método para ejecutar la secuencia de Fibonacci
    static void EjecutarFibonacci()
    {
        Console.Write("Ingrese la posición en la secuencia de Fibonacci: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            return;
        }

        int operaciones = 0;
        var cronometro = new Stopwatch();

        try
        {
            cronometro.Start(); // Iniciar el cronómetro
            BigInteger resultado = Fibonacci(n, ref operaciones); // Calcular el valor de Fibonacci
            cronometro.Stop(); // Detener el cronómetro
            Console.WriteLine($"El elemento en la posición {n} de Fibonacci es: {resultado}");
        }
        catch (Exception e)
        {
            cronometro.Stop(); // Detener el cronómetro si ocurre una excepción
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds:F4} ms");
        Console.WriteLine($"Número de operaciones: {operaciones}");
    }

    // Búsqueda binaria
    static int BusquedaBinaria(int[] arreglo, int izquierda, int derecha, int objetivo, ref int operaciones)
    {
        operaciones++; // Incrementar el contador de operaciones

        // Caso base: si el rango es inválido (izquierda es mayor que derecha)
        // Esto indica que el elemento no está en el arreglo.
        if (izquierda > derecha) return -1;

        // Calcular el punto medio del rango actual
        int medio = izquierda + (derecha - izquierda) / 2;

        // Si el elemento objetivo está en el medio
        if (arreglo[medio] == objetivo) return medio;

        // Si el elemento es menor, solo puede estar en la mitad izquierda
        if (arreglo[medio] > objetivo)
            return BusquedaBinaria(arreglo, izquierda, medio - 1, objetivo, ref operaciones);

        // Si el elemento es mayor, solo puede estar en la mitad derecha
        return BusquedaBinaria(arreglo, medio + 1, derecha, objetivo, ref operaciones);
    }

    // Método para ejecutar la búsqueda binaria
    static void EjecutarBusquedaBinaria()
    {
        Console.Write("Ingrese el tamaño del arreglo ordenado: ");
        if (!int.TryParse(Console.ReadLine(), out int tamaño) || tamaño < 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo.");
            return;
        }

        int[] arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1} (debe estar ordenado): ");
            if (!int.TryParse(Console.ReadLine(), out arreglo[i]))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                return;
            }
        }

        Console.Write("Ingrese el elemento a buscar: ");
        if (!int.TryParse(Console.ReadLine(), out int objetivo))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            return;
        }

        int operaciones = 0;
        var cronometro = new Stopwatch();
        cronometro.Start(); // Iniciar el cronómetro
        int resultado = BusquedaBinaria(arreglo, 0, arreglo.Length - 1, objetivo, ref operaciones);
        cronometro.Stop(); // Detener el cronómetro

        if (resultado != -1)
        {
            Console.WriteLine($"Elemento encontrado en la posición: {resultado}");
        }
        else
        {
            Console.WriteLine("Elemento no encontrado.");
        }

        Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds:F4} ms");
        Console.WriteLine($"Número de operaciones: {operaciones}");
    }

    // Algoritmo de la Torre de Hanoi
    static void Hanoi(int n, char origen, char destino, char auxiliar, ref int operaciones)
    {
        operaciones++; // Incrementar el contador de operaciones

        // Caso base: si no hay discos que mover, terminar la recursión
        // Esto detiene la recursión. Sin este caso base, la función llamaría a sí misma indefinidamente.
        if (n == 0) return;

        // Mover n-1 discos al auxiliar
        Hanoi(n - 1, origen, auxiliar, destino, ref operaciones);

        // Mover el disco restante al destino
        Console.WriteLine($"Mover disco {n} de {origen} a {destino}");

        // Mover los n-1 discos restantes al destino
        Hanoi(n - 1, auxiliar, destino, origen, ref operaciones);
    }

    // Método para ejecutar el algoritmo de la Torre de Hanoi
    static void EjecutarHanoi()
    {
        Console.Write("Ingrese el número de discos: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo.");
            return;
        }

        int operaciones = 0;
        var cronometro = new Stopwatch();
        cronometro.Start(); // Iniciar el cronómetro
        Hanoi(n, 'A', 'C', 'B', ref operaciones); // Ejecutar el algoritmo de la Torre de Hanoi
        cronometro.Stop(); // Detener el cronómetro

        Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds:F4} ms");
        Console.WriteLine($"Número de operaciones: {operaciones}");
    }
}