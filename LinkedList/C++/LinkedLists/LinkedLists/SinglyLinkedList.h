#pragma once
#include "Node.h"

class SinglyLinkedList
{
private:
    Node *m_headPtr = nullptr;
    Node *m_tailPtr = nullptr;
    
public:
    SinglyLinkedList(Node *node)
    {
        m_headPtr = node;
        m_tailPtr = node;
    }

    Node * GetHead() const;
    Node * GetTail() const;

    void Add(Node *node);
    void InsertAfter(Node *nodeA, Node *nodeB);

    Node *FindByValue(std::string value) const;
};
