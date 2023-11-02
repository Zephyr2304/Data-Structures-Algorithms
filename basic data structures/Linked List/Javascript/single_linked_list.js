class Node
{
    constructor()
    {
        this.data=0;
        this.next=null;
    }
}
 
// Function to print the content of
// linked list starting from the
// given node
function printList(n)
{
    // Iterate till n reaches null
  while (n != null)
  {
    // Print the data
    document.write(n.data + " ");
    n = n.next;
  }
}
 
// Driver Code
let head = null;
let second = null;
let third = null;
 
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