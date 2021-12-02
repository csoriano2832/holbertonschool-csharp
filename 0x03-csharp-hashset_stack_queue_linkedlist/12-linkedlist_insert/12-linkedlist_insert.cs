using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        LinkedListNode<int> current;
        
        current = myLList.First;

        while (current != null)
        {
            if (current.Value > n)
            {
                myLList.AddBefore(current, node);
                break;
            }

            current = current.Next;
        }

        return (node);
    }
}
