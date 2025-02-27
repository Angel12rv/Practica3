// Stack.cs
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
    }

    // Pop
    public int? Pop()
    {
        if (top == null)
            return null;
        int poppedData = top.Data;
        top = top.Next;
        return poppedData;
    }

    // Clear
    public void Clear()
    {
        top = null;
    }

    // Search
    public int Search(int key)
    {
        Node current = top;
        int position = 1;
        while (current != null)
        {
            if (current.Data == key)
                return position;
            current = current.Next;
            position++;
        }
        return -1; // No encontrado
    }

    // Obtener la lista de elementos para visualización
    public List<int> GetElements()
    {
        List<int> elements = new List<int>();
        Node current = top;
        while (current != null)
        {
            elements.Add(current.Data);
            current = current.Next;
        }
        return elements;
    }
}

