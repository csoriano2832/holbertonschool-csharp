using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        LinkedListNode<int> current;

        if (myLList == null)
        {
            return (null);
        }

        if (myLList.Count == 0)
        {
            myLList.AddFirst(node);
        }
        else
        {
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
            
            if (current == null)
            {
                myLList.AddLast(node);
            }
        }

        return (node);
    }
}
