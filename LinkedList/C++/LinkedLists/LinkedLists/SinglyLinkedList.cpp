#include "SinglyLinkedList.h"

void SinglyLinkedList::InsertAfter(Node* nodeA, Node* nodeB)
{
    Node *nodeANext = nodeA->GetNext();
    nodeB->SetNext(nodeANext);
    nodeA->SetNext(nodeB);
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

Node* SinglyLinkedList::FindByValue(std::string value) const
{
    Node *currentNode = m_headPtr;

    while (currentNode->GetValue() != value)
    {
        currentNode = currentNode->GetNext();
            
        if (currentNode->GetValue() == value)
        {
            return currentNode;
        }
            
        if (currentNode == m_tailPtr)
        {
            return nullptr;    
        }
    }
}

