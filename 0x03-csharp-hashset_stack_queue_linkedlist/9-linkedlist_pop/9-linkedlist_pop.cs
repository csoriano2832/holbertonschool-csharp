using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> node = myLList.First;
        
        if (node is null)
        {
            return (0);
        }

        return (node.Value);
    }
}
