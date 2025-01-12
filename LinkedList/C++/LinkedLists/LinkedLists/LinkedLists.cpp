
#include "SinglyLinkedList.h"

int main(int argc, char* argv[])
{
    Node *firstNode = new Node("First Node");
    SinglyLinkedList *singlyLinkedList = new SinglyLinkedList(firstNode);

    printf("Head node of list is: %s\n", singlyLinkedList->GetHead()->GetValue().c_str());
    printf("Tail node of list is: %s\n", singlyLinkedList->GetTail()->GetValue().c_str());
    printf("--------------------------------------------------\n");

    Node *nextNode = new Node("Next node");
    singlyLinkedList->Add(nextNode);

    printf("Head node of list is: %s\n", singlyLinkedList->GetHead()->GetValue().c_str());
    printf("Tail node of list is: %s\n", singlyLinkedList->GetTail()->GetValue().c_str());
    printf("--------------------------------------------------\n");

    Node *next2Node = new Node("Next node2");
    singlyLinkedList->Add(next2Node);
    Node *next3Node = new Node("Next node3");
    singlyLinkedList->Add(next3Node);
    Node *next4Node = new Node("Next node4");
    singlyLinkedList->Add(next4Node);
    Node *next5Node = new Node("Next node5");
    singlyLinkedList->Add(next5Node);
    Node *next6Node = new Node("Next node6");
    singlyLinkedList->Add(next6Node);

    Node *foundNode = singlyLinkedList->FindByValue("Next node5");

    printf("Found node with value: %s\n", foundNode->GetValue().c_str());
    printf("--------------------------------------------------\n");

    
    return 0;
}
