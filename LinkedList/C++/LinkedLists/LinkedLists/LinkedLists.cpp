
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
    
    return 0;
}
