#include <cstdio>

class IntStack
{
private:
    const int _defaultSize = 3; 
    int *_backingArray = new int[_defaultSize];
    int _currentSize = _defaultSize;
    int _growSize = 3;
    int _currentIndex = 0;

    void Regrow()
    {
        if (_currentIndex == _currentSize)
        {
            int newSize = _currentSize + _growSize;
            int *newArray = new int[newSize];
            
            for (int index = 0; index < _currentSize; index++)
            {
                newArray[index] = _backingArray[index];
            }

            delete []_backingArray;
            _backingArray = newArray;
            _currentSize = newSize;
        }
    }
    
public:
    int Pop()
    {
        return _backingArray[_currentIndex];
    }

    void Push(int data)
    {
        Regrow();
        _backingArray[_currentIndex] = data;
        _currentIndex++;
    }

    bool IsEmpty()
    {
        
    }
};


int main(int argc, char* argv[])
{
    IntStack *stack = new IntStack();
    stack->Push(1);
    stack->Push(3);
    stack->Push(5);

    int last = stack->Pop();

    printf("Popped value is %d\n", last);
    return 0;
}
