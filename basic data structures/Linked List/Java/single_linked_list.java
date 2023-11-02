class single_linked_list{

    static class Node {
    int data; //here the data type is int(you can assign any datatype)
    // Pointer to next node in LL
    Node next;
};

    static void printList(Node n)
        {
            // Iterate till n reaches null
            while (n != null) {
                // Print the data
                System.out.print(n.data + " ");
                n = n.next;
            }
        }
public static void main(String[] args)
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
