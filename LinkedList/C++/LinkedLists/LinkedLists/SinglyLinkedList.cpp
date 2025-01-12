#include "SinglyLinkedList.h"

void SinglyLinkedList::InsertAfter(Node* nodeA, Node* nodeB)
{
    
}

void SinglyLinkedList::Add(Node* node)
{
    Node *lastNode = m_tailPtr;
    lastNode->SetNext(node);
    m_tailPtr = node;
}


Node * SinglyLinkedList::GetHead() const
{
    return m_headPtr;
}

Node * SinglyLinkedList::GetTail() const
{
    if (m_tailPtr != nullptr)
    {
        return m_tailPtr;
    }
}


