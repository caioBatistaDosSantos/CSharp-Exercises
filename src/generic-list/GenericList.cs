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
        throw new NotImplementedException();
    }

    public int Search(T element)
    {
        throw new NotImplementedException();
    }
    
}