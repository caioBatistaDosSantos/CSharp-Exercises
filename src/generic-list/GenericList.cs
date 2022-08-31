namespace generic_list;

public class GenericList<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;

        public Node(T t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node? Head;

    public GenericList()
    {
        Head = null;
    }

    public void Add(T input) 
    {
        if (Head == null)
        {
            Head = new Node(input);            
        }
        else
        {
            //Encontra onde inserir o próximo nó na lista.
            Node lastNode = Head;
            while(lastNode.Next != null)   lastNode = lastNode.Next;

            lastNode.Next = new Node(input);                        
        }
    }

    public void Print()
    {
        Node? printNode = Head;
        while(printNode.Next != null)
        {
            Console.Write(printNode.Value + " ");
            printNode = printNode.Next;
        }
        Console.WriteLine(printNode.Value);
    }

    public T Index(int index)
    {
        try
        {
            Node indexNode = Head;
            Node? selectedNode = null;
            bool exception = true;

            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    selectedNode = indexNode;
                    exception = false;
                }
                if (indexNode.Next == null && exception)
                    throw new InvalidOperationException("Não há elementos suficientes na lista");
                else indexNode = indexNode.Next;
            }

            return selectedNode.Value;
        }
        catch (InvalidOperationException ex)
        {
            throw ex;
        }
    }

    public int Search(T element)
    {
        try
        {
            Node elementNode = Head;
            int index = 0;

            while(elementNode.Next != null)
            {
                if (elementNode.Value.Equals(element))
                    return index;

                elementNode = elementNode.Next;
                index++;
            }

            if (elementNode.Value.Equals(element))
                return index;
            
            throw new InvalidOperationException("Elemento não está na lista");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
    
}