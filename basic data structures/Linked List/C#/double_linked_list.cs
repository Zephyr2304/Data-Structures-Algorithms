using System;
 
class GFG {
 
    // Structure of Node
    public class Node {
        public int data;
        public Node next;
    };
 
    // Function to print the content of
    // linked list starting from the
    // given node
    static void printList(Node n)
    {
 
        // Iterate till n reaches null
        while (n != null) {
 
            // Print the data
            Console.Write(n.data + " ");
            n = n.next;
        }
    }
 
    // Driver Code
    public static void Main(String[] args)
    {
        Node head = null;
        Node second = null;
        Node third = null;
 
        // Allocate 3 nodes in
        // the heap
        head = new Node();
        second = new Node();
        third = new Node();
 
        // Assign data in first
        // node
        head.data = 1;
 
        // Link first node with
        // second
        head.next = second;
 
        // Assign data to second
        // node
        second.data = 2;
        second.next = third;
 
        // Assign data to third
        // node
        third.data = 3;
        third.next = null;
 
        printList(head);
    }
}
