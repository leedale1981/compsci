#include <cassert>
#include <iostream>

class IndexOutOfBoundsException{};

class IntArray
{
private:
    int * m_ptr{nullptr};
    int m_size{0};

    bool IsValidIndex(int index) const
    {
        return (index >= 0) && (index < m_size);
    }
    
public:
    IntArray() = default;

    IntArray(const IntArray& source)
    {
        if (!source.IsEmpty())
        {
            m_size = source.Size();
            m_ptr = new int[m_size]{};

            for (int i = 0; i < m_size; i++)
            {
                m_ptr[i] = source.m_ptr[i];
            }
        }
    }

    explicit IntArray(int size)
    {
        if (size != 0)
        {
            m_ptr = new int[size]{};
            m_size = size;
        }
    }

    int Size() const
    {
        return m_size;
    }

    bool IsEmpty() const
    {
        return (m_size == 0);
    }

    ~IntArray()
    {
        delete[] m_ptr;
    }

    int& operator[] (int index)
    {
        if (!IsValidIndex(index))
        {
            throw IndexOutOfBoundsException{};
        }

        return m_ptr[index];
    }
    
    int operator[] (int index) const
    {
        if (!IsValidIndex(index))
        {
            throw IndexOutOfBoundsException{};
        }
        
        return m_ptr[index];
    }

    int SearchLinear(const int element) const
    {
        for (int i = 0; i < m_size; i++)
        {
            if (m_ptr[i] == element)
            {
                return i;
            }
        }

        return -1;
    }

    int SearchBinary(const int element) const
    {
        int left = 0;
        int right = m_size - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (m_ptr[middle] == element)
            {
                return middle;
            }

            if (m_ptr[middle] < element)
            {
                left = middle + 1;
            }

            if (m_ptr[middle] > element)
            {
                right = middle - 1;
            }
        }
    }

    int SearchBinaryRec(const int element, int left, int right) const
    {
        int middle = (left + right) / 2;
        
        if (m_ptr[middle] == element)
        {
            return middle;
        }

        if (m_ptr[middle] < element)
        {
            return SearchBinaryRec(element, middle + 1, right);
        }

        if (m_ptr[middle] > element)
        {
            return SearchBinaryRec(element, left, middle - 1);
        }
    }
};

std::ostream& operator<< (std::ostream& os, const IntArray& a)
{
    os << "[ ";

    for (int i = 0; i < a.Size(); i++)
    {
        os << a[i] << ' ';
    }
        
    os << "]";
    return os;
}

int main()
{
    using std::cout;
    cout << " Creating an array.\n";
    IntArray a{7};
    a[0] = 11;
    a[1] = 22;
    a[2] = 33;
    a[3] = 64;
    a[4] = 77;
    a[5] = 80;
    a[6] = 88;

    int indexLinear = a.SearchLinear(80);
    int indexBinary = a.SearchBinary(80);
    int indexBinaryRec = a.SearchBinaryRec(80, 0, 6);

    cout << indexLinear << '\n';
    cout << indexBinary << '\n';
    cout << indexBinaryRec << '\n';
}