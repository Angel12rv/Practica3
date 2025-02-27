using System;

namespace EstructurasDeDatos
{
    // Nodo para Listas Enlazadas Simples, Dobles y Circulares
    public class Node
    {
        public int Data;
        public Node Next;
        public Node Prev; // Solo para listas dobles

        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    // Implementación de Pila (Stack)
    public class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        // Push
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
            Console.WriteLine($"Pushed {data} onto the stack.");
            Display();
        }

        // Pop
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }
            Console.WriteLine($"Popped {top.Data} from the stack.");
            top = top.Next;
            Display();
        }

        // Vaciar
        public void Clear()
        {
            top = null;
            Console.WriteLine("La pila ha sido vaciada.");
            Display();
        }

        // Buscar
        public void Search(int key)
        {
            Node current = top;
            int position = 1;
            while (current != null)
            {
                if (current.Data == key)
                {
                    Console.WriteLine($"Elemento {key} encontrado en la posición {position} de la pila.");
                    return;
                }
                current = current.Next;
                position++;
            }
            Console.WriteLine($"Elemento {key} no encontrado en la pila.");
        }

        // Mostrar la pila
        public void Display()
        {
            Console.Write("Stack [Top -> Bottom]: ");
            Node current = top;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    // Implementación de Cola (Queue)
    public class Queue
    {
        private Node front;
        private Node rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        // Enqueue
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                front = rear = newNode;
                Console.WriteLine($"Enqueued {data} into the queue.");
                Display();
                return;
            }
            rear.Next = newNode;
            rear = newNode;
            Console.WriteLine($"Enqueued {data} into la cola.");
            Display();
        }

        // Dequeue
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }
            Console.WriteLine($"Dequeued {front.Data} from la cola.");
            front = front.Next;
            if (front == null)
                rear = null;
            Display();
        }

        // Vaciar
        public void Clear()
        {
            front = rear = null;
            Console.WriteLine("La cola ha sido vaciada.");
            Display();
        }

        // Buscar
        public void Search(int key)
        {
            Node current = front;
            int position = 1;
            while (current != null)
            {
                if (current.Data == key)
                {
                    Console.WriteLine($"Elemento {key} encontrado en la posición {position} de la cola.");
                    return;
                }
                current = current.Next;
                position++;
            }
            Console.WriteLine($"Elemento {key} no encontrado en la cola.");
        }

        // Mostrar la cola
        public void Display()
        {
            Console.Write("Queue [Front -> Rear]: ");
            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    // Implementación de Lista Enlazada Simple
    public class SinglyLinkedList
    {
        private Node head;

        public SinglyLinkedList()
        {
            head = null;
        }

        // Agregar al final
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine($"Agregado {data} a la lista enlazada.");
                Display();
                return;
            }
            Node current = head;
            while (current.Next != null)
                current = current.Next;
            current.Next = newNode;
            Console.WriteLine($"Agregado {data} a la lista enlazada.");
            Display();
        }

        // Eliminar por valor
        public void Remove(int key)
        {
            if (head == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (head.Data == key)
            {
                head = head.Next;
                Console.WriteLine($"Eliminado {key} de la lista enlazada.");
                Display();
                return;
            }

            Node current = head;
            Node previous = null;
            while (current != null && current.Data != key)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine($"Elemento {key} no encontrado en la lista enlazada.");
                return;
            }

            previous.Next = current.Next;
            Console.WriteLine($"Eliminado {key} de la lista enlazada.");
            Display();
        }

        // Vaciar
        public void Clear()
        {
            head = null;
            Console.WriteLine("La lista enlazada ha sido vaciada.");
            Display();
        }

        // Buscar
        public void Search(int key)
        {
            Node current = head;
            int position = 1;
            while (current != null)
            {
                if (current.Data == key)
                {
                    Console.WriteLine($"Elemento {key} encontrado en la posición {position} de la lista enlazada.");
                    return;
                }
                current = current.Next;
                position++;
            }
            Console.WriteLine($"Elemento {key} no encontrado en la lista enlazada.");
        }

        // Mostrar la lista
        public void Display()
        {
            Console.Write("Singly Linked List: ");
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    // Implementación de Lista Doblemente Enlazada
    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        // Agregar al final
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                Console.WriteLine($"Agregado {data} a la lista doblemente enlazada.");
                Display();
                return;
            }
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
            Console.WriteLine($"Agregado {data} a la lista doblemente enlazada.");
            Display();
        }

        // Eliminar por valor
        public void Remove(int key)
        {
            if (head == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Node current = head;
            while (current != null && current.Data != key)
                current = current.Next;

            if (current == null)
            {
                Console.WriteLine($"Elemento {key} no encontrado en la lista doblemente enlazada.");
                return;
            }

            if (current == head)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
                else
                    tail = null;
            }
            else if (current == tail)
            {
                tail = tail.Prev;
                tail.Next = null;
            }
            else
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
            }

            Console.WriteLine($"Eliminado {key} de la lista doblemente enlazada.");
            Display();
        }

        // Vaciar
        public void Clear()
        {
            head = tail = null;
            Console.WriteLine("La lista doblemente enlazada ha sido vaciada.");
            Display();
        }

        // Buscar
        public void Search(int key)
        {
            Node current = head;
            int position = 1;
            while (current != null)
            {
                if (current.Data == key)
                {
                    Console.WriteLine($"Elemento {key} encontrado en la posición {position} de la lista doblemente enlazada.");
                    return;
                }
                current = current.Next;
                position++;
            }
            Console.WriteLine($"Elemento {key} no encontrado en la lista doblemente enlazada.");
        }

        // Mostrar la lista
        public void Display()
        {
            Console.Write("Doubly Linked List: ");
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    // Implementación de Lista Circular
    public class CircularLinkedList
    {
        private Node tail;

        public CircularLinkedList()
        {
            tail = null;
        }

        // Agregar al final
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (tail == null)
            {
                tail = newNode;
                tail.Next = tail;
                Console.WriteLine($"Agregado {data} a la lista circular.");
                Display();
                return;
            }
            newNode.Next = tail.Next;
            tail.Next = newNode;
            tail = newNode;
            Console.WriteLine($"Agregado {data} a la lista circular.");
            Display();
        }

        // Eliminar por valor
        public void Remove(int key)
        {
            if (tail == null)
            {
                Console.WriteLine("La lista circular está vacía.");
                return;
            }

            Node current = tail.Next;
            Node previous = tail;
            bool found = false;

            do
            {
                if (current.Data == key)
                {
                    found = true;
                    break;
                }
                previous = current;
                current = current.Next;
            } while (current != tail.Next);

            if (!found)
            {
                Console.WriteLine($"Elemento {key} no encontrado en la lista circular.");
                return;
            }

            if (current == tail && current.Next == tail) // Solo un elemento
            {
                tail = null;
            }
            else
            {
                previous.Next = current.Next;
                if (current == tail)
                    tail = previous;
            }

            Console.WriteLine($"Eliminado {key} de la lista circular.");
            Display();
        }

        // Vaciar
        public void Clear()
        {
            tail = null;
            Console.WriteLine("La lista circular ha sido vaciada.");
            Display();
        }

        // Buscar
        public void Search(int key)
        {
            if (tail == null)
            {
                Console.WriteLine("La lista circular está vacía.");
                return;
            }

            Node current = tail.Next;
            int position = 1;
            do
            {
                if (current.Data == key)
                {
                    Console.WriteLine($"Elemento {key} encontrado en la posición {position} de la lista circular.");
                    return;
                }
                current = current.Next;
                position++;
            } while (current != tail.Next);

            Console.WriteLine($"Elemento {key} no encontrado en la lista circular.");
        }

        // Mostrar la lista
        public void Display()
        {
            if (tail == null)
            {
                Console.WriteLine("Lista Circular: Vacía.");
                return;
            }

            Console.Write("Circular Linked List: ");
            Node current = tail.Next;
            do
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            } while (current != tail.Next);
            Console.WriteLine("(back to start)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Queue queue = new Queue();
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            CircularLinkedList circularLinkedList = new CircularLinkedList();

            while (true)
            {
                Console.WriteLine("\nSeleccione la estructura de datos:");
                Console.WriteLine("1. Pila (Stack)");
                Console.WriteLine("2. Cola (Queue)");
                Console.WriteLine("3. Lista Enlazada Simple");
                Console.WriteLine("4. Lista Doblemente Enlazada");
                Console.WriteLine("5. Lista Circular");
                Console.WriteLine("6. Salir");
                Console.Write("Opción: ");
                string estructuraOpcion = Console.ReadLine();

                switch (estructuraOpcion)
                {
                    case "1":
                        OperacionesPila(stack);
                        break;
                    case "2":
                        OperacionesCola(queue);
                        break;
                    case "3":
                        OperacionesListaEnlazada(singlyLinkedList);
                        break;
                    case "4":
                        OperacionesListaDoble(doublyLinkedList);
                        break;
                    case "5":
                        OperacionesListaCircular(circularLinkedList);
                        break;
                    case "6":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

        // Métodos para operaciones de la Pila
        static void OperacionesPila(Stack stack)
        {
            while (true)
            {
                Console.WriteLine("\nOperaciones de la Pila:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Vaciar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el valor a Push: ");
                        if (int.TryParse(Console.ReadLine(), out int pushVal))
                        {
                            stack.Push(pushVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        stack.Clear();
                        break;
                    case "4":
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int searchVal))
                        {
                            stack.Search(searchVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "5":
                        stack.Display();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        // Métodos para operaciones de la Cola
        static void OperacionesCola(Queue queue)
        {
            while (true)
            {
                Console.WriteLine("\nOperaciones de la Cola:");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Vaciar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el valor a Enqueue: ");
                        if (int.TryParse(Console.ReadLine(), out int enqueueVal))
                        {
                            queue.Enqueue(enqueueVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "2":
                        queue.Dequeue();
                        break;
                    case "3":
                        queue.Clear();
                        break;
                    case "4":
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int searchVal))
                        {
                            queue.Search(searchVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "5":
                        queue.Display();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        // Métodos para operaciones de la Lista Enlazada Simple
        static void OperacionesListaEnlazada(SinglyLinkedList list)
        {
            while (true)
            {
                Console.WriteLine("\nOperaciones de la Lista Enlazada Simple:");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Vaciar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el valor a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int addVal))
                        {
                            list.Add(addVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "2":
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int removeVal))
                        {
                            list.Remove(removeVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "3":
                        list.Clear();
                        break;
                    case "4":
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int searchVal))
                        {
                            list.Search(searchVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "5":
                        list.Display();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        // Métodos para operaciones de la Lista Doblemente Enlazada
        static void OperacionesListaDoble(DoublyLinkedList list)
        {
            while (true)
            {
                Console.WriteLine("\nOperaciones de la Lista Doblemente Enlazada:");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Vaciar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el valor a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int addVal))
                        {
                            list.Add(addVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "2":
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int removeVal))
                        {
                            list.Remove(removeVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "3":
                        list.Clear();
                        break;
                    case "4":
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int searchVal))
                        {
                            list.Search(searchVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "5":
                        list.Display();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        // Métodos para operaciones de la Lista Circular
        static void OperacionesListaCircular(CircularLinkedList list)
        {
            while (true)
            {
                Console.WriteLine("\nOperaciones de la Lista Circular:");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Vaciar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el valor a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int addVal))
                        {
                            list.Add(addVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "2":
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int removeVal))
                        {
                            list.Remove(removeVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "3":
                        list.Clear();
                        break;
                    case "4":
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int searchVal))
                        {
                            list.Search(searchVal);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "5":
                        list.Display();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}