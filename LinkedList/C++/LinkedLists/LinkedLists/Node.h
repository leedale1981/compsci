#pragma once
#include <string>

class Node
{
private:
    Node *m_nextPtr = nullptr;
    Node *m_previousPtr = nullptr;
    std::string m_value;
    
public:
    Node(std::string value)
    {
        m_value = value;
    }

    Node *GetNext();
    void SetNext(Node *node);
    Node *GetPrevious();
    void SetPrevious(Node *node);
    std::string GetValue();
};
