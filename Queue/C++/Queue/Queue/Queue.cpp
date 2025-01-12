#include <cstdio>
#include <cstdlib>

class IntQueue
{
private:
    const int DefaultSize = 3;
    int *_backingArray = new int[DefaultSize];
    int _currentSize = DefaultSize;
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
    void Enqueue(int value)
    {
        Regrow();
        _backingArray[_currentIndex] = value;
        _currentIndex++;
    }

    int Peek()
    {
        return _backingArray[0];
    }

    int Dequeue()
    {
        int latest = _backingArray[0];
        _currentSize--;
        int *newArray = new int[_currentSize];
        for (int index = 0; index < _currentIndex; index++)
        {
            newArray[index] = _backingArray[index + 1];
        }

        free(_backingArray);
        _backingArray = newArray;
        return latest;
    }
};

int main(int argc, char* argv[])
{
    IntQueue *queue = new IntQueue();
    queue->Enqueue(3);
    queue->Enqueue(7);
    int latest = queue->Dequeue();
    printf("Latest value: %d\n", latest);

    int nextLatest = queue->Dequeue();
    printf("Next latest value: %d\n", nextLatest);
    return 0;
}
