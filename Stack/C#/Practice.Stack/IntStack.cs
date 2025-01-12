namespace Practice.Stack;

public class IntStack
{
    private const int DefaultSize = 10;
    private int[] _backingArray = new int[DefaultSize];
    private int _currentSize = DefaultSize;
    private int _growSize = 2;
    private int _currentIndex = 0;

    public int Pop()
    {
        return _backingArray[_currentIndex];
    }

    public void Push(int value)
    {
        Regrow();
        _backingArray[_currentIndex] = value;
        _currentIndex++;
    }

    private void Regrow()
    {
        if (_currentIndex == _currentSize)
        {
            int[] newArray = new int[_growSize * _currentSize];
            Array.Copy(_backingArray, newArray, _currentSize);
            _backingArray = newArray;
            _currentSize = _growSize * _currentSize;

        }
    }
}