using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == null)
            return (0);

        LinkedListNode<int> node = myLList.First;
        
        if (node == null)
            return (0);

        myLList.RemoveFirst();
        return (node.Value);
    }
}
