#include "Node.h"

std::string Node::GetValue()
{
    return m_value;
}

Node* Node::GetNext()
{
    return m_nextPtr;
}

Node* Node::GetPrevious()
{
    return m_previousPtr;
}

void Node::SetNext(Node* node)
{
    m_nextPtr = node;
}

void Node::SetPrevious(Node* node)
{
    m_previousPtr = node;
}




