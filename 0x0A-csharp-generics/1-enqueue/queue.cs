using System;

///<summary>A generic Queue class</summary>
public class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    ///<summary>Returns the type of the Queue that was created</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>A Node class implementation within a Queue</summary>
    public class Node
    {
        private T value = default(T);
        ///<summary>The next node in the queue</summary> 
        public Node next = null;

        ///<summary>Constructor method for a Node class</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    ///<summary>Adds a new node at the end of the queue</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count += 1;
        
    }

    ///<summary>Returns the number of nodes in the queue</summary>
    public int Count()
    {
        return count;
    }
}
