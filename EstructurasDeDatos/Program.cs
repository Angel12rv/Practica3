using System;

public class Nodo //La clase nodo q se usa para todas las funciones
{
    public int dato;  // La variable donde se almacena el dato
    public Nodo siguiente;  // El apuntador al siguiente nodo
    public Nodo anterior;  // Apuntador para las listas dobles

    public Nodo(int valor)
    {
        dato = valor;
        siguiente = null;
        anterior = null;
    }
}
public class Pila
{
    private Nodo cima;

    public Pila()
    {
        cima = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        nuevo.siguiente = cima;
        cima = nuevo;
        Mostrar();
    }

    public void Eliminar()
    {
        if (cima != null)
        {
            cima = cima.siguiente;
            Mostrar();
        }
        else
        {
            Console.WriteLine("La pila no tiene datos todavia");
        }
    }

    public void Vaciar()
    {
        cima = null;
        Mostrar();
    }

    public void Mostrar()
    {
        Nodo actual = cima;
        Console.WriteLine("Pila:");
        while (actual != null)
        {
            Console.WriteLine(actual.dato);
            actual = actual.siguiente;
        }
    }

    public void Buscar(int valor)
    {
        Nodo actual = cima;
        int posicion = 0;
        bool encontrado = false;
        while (actual != null)
        {
            if (actual.dato == valor)
            {
                Console.WriteLine($"Valor {valor} encontrado en la posición {posicion}");
                encontrado = true;
                break;
            }
            actual = actual.siguiente;
            posicion++;
        }
        if (!encontrado)
        {
            Console.WriteLine($"Valor {valor} no encontrado en la pila.");
        }
    }
}
public class Cola
{
    private Nodo frente;
    private Nodo final;

    public Cola()
    {
        frente = null;
        final = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (final != null)
        {
            final.siguiente = nuevo;
        }
        final = nuevo;
        if (frente == null)
        {
            frente = nuevo;
        }
        Mostrar();
    }

    public void Eliminar()
    {
        if (frente != null)
        {
            frente = frente.siguiente;
            if (frente == null)
            {
                final = null;
            }
            Mostrar();
        }
        else
        {
            Console.WriteLine("La cola no tiene datos todavia");
        }
    }

    public void Vaciar()
    {
        frente = null;
        final = null;
        Mostrar();
    }

    public void Mostrar()
    {
        Nodo actual = frente;
        Console.WriteLine("Cola:");
        while (actual != null)
        {
            Console.WriteLine(actual.dato);
            actual = actual.siguiente;
        }
    }

    public void Buscar(int valor)
    {
        Nodo actual = frente;
        int posicion = 0;
        bool encontrado = false;
        while (actual != null)
        {
            if (actual.dato == valor)
            {
                Console.WriteLine($"Valor {valor} encontrado en la posición {posicion}");
                encontrado = true;
                break;
            }
            actual = actual.siguiente;
            posicion++;
        }
        if (!encontrado)
        {
            Console.WriteLine($"Valor {valor} no encontrado en la cola.");
        }
    }
}
public class ListaSimple
{
    private Nodo inicio;

    public ListaSimple()
    {
        inicio = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (inicio == null)
        {
            inicio = nuevo;
        }
        else
        {
            Nodo actual = inicio;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevo;
        }
        Mostrar();
    }

    public void AgregarPorPosicion(int valor, int posicion)
    {
        if (posicion < 0)
        {
            Console.WriteLine("No puede ser una posicion negativa");
            return;
        }

        Nodo nuevo = new Nodo(valor);

        // Si la lista está vacía y la posición es 0
        if (inicio == null && posicion == 0)
        {
            inicio = nuevo;
        }
        else if (inicio == null)
        {
            // Si la lista está vacía y la posición no es 0
            Console.WriteLine("No puedes agregar por posicion mientras la lista esta vacia,Solamente en posicion 0");
            return;
        }
        else if (posicion == 0)
        {
            // Agregar al inicio
            nuevo.siguiente = inicio;
            inicio = nuevo;
        }
        else
        {
            // Agregar en una posición específica (mayor que 0)
            Nodo actual = inicio;
            int contador = 0;
            while (contador < posicion - 1 && actual.siguiente != null)
            {
                actual = actual.siguiente;
                contador++;
            }

            // Verificar si la posición es válida
            if (contador == posicion - 1)
            {
                nuevo.siguiente = actual.siguiente;
                actual.siguiente = nuevo;
            }
            else
            {
                Console.WriteLine("La posicion esta fuera del limite");
            }
        }
        Mostrar();
    }

    public void Eliminar()
    {
        if (inicio != null)
        {
            inicio = inicio.siguiente;
            Mostrar();
        }
        else
        {
            Console.WriteLine("La lista no tiene datos todavia");
        }
    }

    public void EliminarPorPosicion(int posicion)
    {
        if (posicion == 0 && inicio != null)
        {
            inicio = inicio.siguiente;
        }
        else
        {
            Nodo actual = inicio;
            int contador = 0;
            while (contador < posicion - 1 && actual != null)
            {
                actual = actual.siguiente;
                contador++;
            }
            if (actual != null && actual.siguiente != null)
            {
                actual.siguiente = actual.siguiente.siguiente;
            }
        }
        Mostrar();
    }

    public void Vaciar()
    {
        inicio = null;
        Mostrar();
    }

    public void Mostrar()
    {
        Nodo actual = inicio;
        Console.WriteLine("Lista Simple:");
        while (actual != null)
        {
            Console.WriteLine(actual.dato);
            actual = actual.siguiente;
        }
    }

    public void Buscar(int valor)
    {
        Nodo actual = inicio;
        int posicion = 0;
        bool encontrado = false;
        while (actual != null)
        {
            if (actual.dato == valor)
            {
                Console.WriteLine($"Valor {valor} encontrado en la posición {posicion}");
                encontrado = true;
                break;
            }
            actual = actual.siguiente;
            posicion++;
        }
        if (!encontrado)
        {
            Console.WriteLine($"Valor {valor} no encontrado en la lista.");
        }
    }
}
public class ListaDoble
{
    private Nodo inicio;  
    private Nodo fin;    
    public ListaDoble()
    {
        inicio = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (inicio == null)
        {
            inicio = nuevo;
        }
        else
        {
            Nodo actual = inicio;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevo;
            nuevo.anterior = actual;
        }
        Mostrar();
   }

    public void AgregarPorPosicion(int valor, int posicion)
    {
        if (posicion < 0)
        {
            Console.WriteLine("No puede ser una posicion negativa");
            return;
        }

        Nodo nuevo = new Nodo(valor);

        if (inicio == null && posicion == 0)
        {
            inicio = nuevo;
            fin = nuevo;
        }
        else if (inicio == null)
        {
            Console.WriteLine("No se puede agregar en una lista vacia,Solo en posicion 0");
            return;
        }
        else if (posicion == 0)
        {
            nuevo.siguiente = inicio;
            inicio.anterior = nuevo;
            inicio = nuevo;
        }
        else
        {
            Nodo actual = inicio;
            int contador = 0;
            while (contador < posicion - 1 && actual.siguiente != null)
            {
                actual = actual.siguiente;
                contador++;
            }

            if (contador == posicion - 1)
            {
                nuevo.siguiente = actual.siguiente;
                nuevo.anterior = actual;

                if (actual.siguiente != null)
                {
                    actual.siguiente.anterior = nuevo;
                }

                actual.siguiente = nuevo;

                if (nuevo.siguiente == null)
                {
                    fin = nuevo;
                }
            }
            else
            {
                Console.WriteLine("La posicion esta fuera de los limites");
            }
        }
        Mostrar();
    }

    public void Eliminar()
    {
        if (inicio != null)
        {
            inicio = inicio.siguiente;
            if (inicio != null)
            {
                inicio.anterior = null;
            }
            Mostrar();
        }
        else
        {
            Console.WriteLine("La lista doble no tiene datos todavia");
        }
    }

    public void EliminarPorPosicion(int posicion)
    {
        if (posicion == 0 && inicio != null)
        {
            inicio = inicio.siguiente;
            if (inicio != null)
            {
                inicio.anterior = null;
            }
        }
        else
        {
            Nodo actual = inicio;
            int contador = 0;
            while (contador < posicion - 1 && actual != null)
            {
                actual = actual.siguiente;
                contador++;
            }
            if (actual != null && actual.siguiente != null)
            {
                Nodo temp = actual.siguiente;
                actual.siguiente = temp.siguiente;
                if (temp.siguiente != null)
                {
                    temp.siguiente.anterior = actual;
                }
            }
        }
        Mostrar();
    }

    public void Vaciar()
    {
        inicio = null;
        Mostrar();
    }

    public void Mostrar()
    {
        Nodo actual = inicio;
        Console.WriteLine("Lista Doble:");
        while (actual != null)
        {
            Console.WriteLine(actual.dato);
            actual = actual.siguiente;
        }
    }

    public void Buscar(int valor)
    {
        Nodo actual = inicio;
        int posicion = 0;
        bool encontrado = false;
        while (actual != null)
        {
            if (actual.dato == valor)
            {
                Console.WriteLine($"Valor {valor} encontrado en la posición {posicion}");
                encontrado = true;
                break;
            }
            actual = actual.siguiente;
            posicion++;
        }
        if (!encontrado)
        {
            Console.WriteLine($"Valor {valor} no encontrado en la lista.");
        }
    }
}
public class ListaCircular
{
    private Nodo ultimo;
    private Nodo inicio;

    public ListaCircular()
    {
        ultimo = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (ultimo == null)
        {
            ultimo = nuevo;
            ultimo.siguiente = ultimo;
        }
        else
        {
            nuevo.siguiente = ultimo.siguiente;
            ultimo.siguiente = nuevo;
            ultimo = nuevo;
        }
        Mostrar();
    }

    public void AgregarPorPosicion(int valor, int posicion)
    {
        if (posicion < 0)
        {
            Console.WriteLine("No puede ser una posicion negativa");
            return;
        }

        Nodo nuevo = new Nodo(valor);

        if (inicio == null && posicion == 0)
        {
            inicio = nuevo;
            ultimo = nuevo;
        }
        else if (inicio == null)
        {
            Console.WriteLine("La lista esta vacia,solo puedes agregar en posicion 0");
            return;
        }
        else if (posicion == 0)
        {
            nuevo.siguiente = inicio;
            inicio.anterior = nuevo;
            inicio = nuevo;
        }
        else
        {
            Nodo actual = inicio;
            int contador = 0;
            while (contador < posicion - 1 && actual.siguiente != null)
            {
                actual = actual.siguiente;
                contador++;
            }

            if (contador == posicion - 1)
            {
                nuevo.siguiente = actual.siguiente;
                nuevo.anterior = actual;

                if (actual.siguiente != null)
                {
                    actual.siguiente.anterior = nuevo;
                }

                actual.siguiente = nuevo;

                if (nuevo.siguiente == null)
                {
                     ultimo=nuevo;
                }
            }
            else
            {
                Console.WriteLine("La posicion esta fuera de los limites");
            }
        }
        Mostrar();
    }

    public void Eliminar()
    {
        if (ultimo != null)
        {
            if (ultimo.siguiente == ultimo)
            {
                ultimo = null;
            }
            else
            {
                Nodo primero = ultimo.siguiente;
                ultimo.siguiente = primero.siguiente;
            }
            Mostrar();
        }
        else
        {
            Console.WriteLine("La lista circular no tiene datos todavia");
        }
    }

    public void EliminarPorPosicion(int posicion)
    {
        if (posicion == 0 && ultimo != null)
        {
            if (ultimo.siguiente == ultimo)
            {
                ultimo = null;
            }
            else
            {
                ultimo.siguiente = ultimo.siguiente.siguiente;
            }
        }
        else
        {
            Nodo actual = ultimo.siguiente;
            int contador = 0;
            while (contador < posicion - 1 && actual != ultimo)
            {
                actual = actual.siguiente;
                contador++;
            }
            if (actual.siguiente != null && actual != ultimo)
            {
                actual.siguiente = actual.siguiente.siguiente;
                if (actual.siguiente == ultimo.siguiente)
                {
                    ultimo = actual;
                }
            }
        }
        Mostrar();
    }

    public void Vaciar()
    {
        ultimo = null;
        Mostrar();
    }

    public void Mostrar()
    {
        if (ultimo != null)
        {
            Nodo actual = ultimo.siguiente;
            Console.WriteLine("Lista Circular:");
            do
            {
                Console.WriteLine(actual.dato);
                actual = actual.siguiente;
            } while (actual != ultimo.siguiente);
        }
    }

    public void Buscar(int valor)
    {
        if (ultimo != null)
        {
            Nodo actual = ultimo.siguiente;
            int posicion = 0;
            bool encontrado = false;
            do
            {
                if (actual.dato == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado en la posición {posicion}");
                    encontrado = true;
                    break;
                }
                actual = actual.siguiente;
                posicion++;
            } while (actual != ultimo.siguiente);
            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} no encontrado en la lista circular.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        ListaSimple listaSimple = new ListaSimple();
        ListaDoble listaDoble = new ListaDoble();
        ListaCircular listaCircular = new ListaCircular();

        int opcion = 0;

        do
        {
            Console.WriteLine("1-Pila");
            Console.WriteLine("2-Cola");
            Console.WriteLine("3-Lista Simple");
            Console.WriteLine("4-Lista Doble");
            Console.WriteLine("5-Lista Circular");
            Console.WriteLine("6-Salir");
            Console.Write("Elije una opcion");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MenuEstructura(pila);
                    break;
                case 2:
                    MenuEstructura(cola);
                    break;
                case 3:
                    MenuLista(listaSimple);
                    break;
                case 4:
                    MenuLista(listaDoble);
                    break;
                case 5:
                    MenuLista(listaCircular);
                    break;
                case 6:
                    Console.WriteLine("Cerrando el prgorama");
                    break;
                default:
                    Console.WriteLine("No es una opcion");
                    break;
            }
        } while (opcion != 6);
    }

    static void MenuEstructura(dynamic estructura)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("1-Agregar");
            Console.WriteLine("2-Eliminar");
            Console.WriteLine("3-Vaciar");
            Console.WriteLine("4-Mostrar");
            Console.WriteLine("5-Buscar");
            Console.WriteLine("6-Volver");
            Console.Write("Elije una opcion");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("ingresa el valor");
                    int valor = int.Parse(Console.ReadLine());
                    estructura.Agregar(valor);
                    break;
                case 2:
                    estructura.Eliminar();
                    break;
                case 3:
                    estructura.Vaciar();
                    break;
                case 4:
                    estructura.Mostrar();
                    break;
                case 5:
                    Console.Write("Que valor buscar");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    estructura.Buscar(valorBuscar);
                    break;
                case 6:
                    Console.WriteLine("Regresando");
                    break;
                default:
                    Console.WriteLine("No es una opcion");
                    break;
            }
        } while (opcion != 6);
    }

    static void MenuLista(dynamic lista)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("1-Agregar");
            Console.WriteLine("2-Agregar por posición");
            Console.WriteLine("3-Eliminar");
            Console.WriteLine("4-Eliminar por posición");
            Console.WriteLine("5-Vaciar");
            Console.WriteLine("6-Mostrar");
            Console.WriteLine("7-Buscar");
            Console.WriteLine("8-Volver al menu");
            Console.Write("Elije la opcion");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("ingresa el valor");
                    int valor = int.Parse(Console.ReadLine());
                    lista.Agregar(valor);
                    break;
                case 2:
                    Console.Write("ingresa el valor");
                    valor = int.Parse(Console.ReadLine());
                    Console.Write("ingresa la posicion");
                    int posicion = int.Parse(Console.ReadLine());
                    lista.AgregarPorPosicion(valor, posicion);
                    break;
                case 3:
                    lista.Eliminar();
                    break;
                case 4:
                    Console.Write("En que posicion a eliminar");
                    posicion = int.Parse(Console.ReadLine());
                    lista.EliminarPorPosicion(posicion);
                    break;
                case 5:
                    lista.Vaciar();
                    break;
                case 6:
                    lista.Mostrar();
                    break;
                case 7:
                    Console.Write("ingresa el valor a buscar");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    lista.Buscar(valorBuscar);
                    break;
                case 8:
                    Console.WriteLine("Regresando");
                    break;
                default:
                    Console.WriteLine("No es una opcion");
                    break;
            }
        } while (opcion != 8);
    }
}