using System;

public class Node
{
    public int data; 
    public Node next; 
                      
    public Node(int value)
    {
        this.data = value;
        this.next = null;
    }
}

public class Program
{
   
    public static int Length(Node head)
    {
        Node temp = head;
        int count = 0;
        while (temp != null) 
        {
            count++; 
            temp = temp.next; 
        }
        return count;
    }
    
    public static void PrintList(Node head)
    {
        Node ptr = head;
        while (ptr != null) 
        {
            Console.Write(ptr.data + " ");
            ptr = ptr.next; 
        }
        Console.WriteLine(); 
    }

    
    public static Node DeleteNthNodeFromEnd(Node head,
                                            int n)
    {
        int Length = Program.Length(
            head);
        int nodeFromBeginning
            = Length - n
            + 1; 
        Node prev = null;
        Node temp = head;
        for (int i = 1; i < nodeFromBeginning;
            i++) 
        {
            prev = temp;
            temp = temp.next;
        }
        if (prev
            == null)
        {
            head = head.next; 
            return head; 
        }
        else 
        {
            prev.next
                = prev.next
                    .next; 
                          
            return head; 
        }
    }

    public static void Main()
    {
        
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);
        head.next.next.next = new Node(4);
        head.next.next.next.next = new Node(5);

        
        Console.WriteLine("Linked List before Deletion:");
        Program.PrintList(head);

        
        head = Program.DeleteNthNodeFromEnd(head, 5);

    
        Console.WriteLine("Linked List after Deletion:");
        Program.PrintList(head);
    }
}
