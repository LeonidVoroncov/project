using System;

public class ElementCollection
{
    private Element _first;
    public int Count { get; private set; }

    public ElementCollection()
    {
        _first = new Element
        {
            Value = 0,
            Next = null
        };
        Count = 0;
    }
    public int Get(int index)
    {
        return GetElement(index).Value;
    }

    private Element GetElement(int index)
    {
        if (index > Count)
            throw new IndexOutOfRangeException();
        var current = _first;
        for (var i = 1; i < index; i++)
        {
            current = current.Next;
        }
        return current;
    }
    //-------------------------------------------------------------
    public void Enqueue(int value)
    {
        if (Count < 1)
        {
            _first = new Element
            {
                Value = value,
                Next = null
            };
        }
        else
        {
            var newEnd = new Element
            {
                Next = null,
                Value = value
            };

            var end = GetElement(Count);
            end.Next = newEnd;            
        }
        Count++;

    }
    public int Dequeue()
    {
        var deletedValue = _first.Value;
        if (Count > 1)
        {
            _first = _first.Next;
            Count--;
        }       
        return deletedValue;
    }
    public int Peek()
    {
        var firstChild = _first.Value;
        return firstChild;
    }
}




public class ElementCollectionStack 
{
    private Element _first;
    public int CountStack { get; private set; }

    public ElementCollectionStack()
    {
        _first = new Element
        {
            Value = 0,
            Next = null
        };
        CountStack = 0;
    }
    public int Get(int index)
    {
        return GetElement(index).Value;
    }

    private Element GetElement(int index)
    {
        if (index > CountStack)
            throw new IndexOutOfRangeException();
        var current = _first;
        for (var i = 1; i < index; i++)
        {
            current = current.Next;
        }
        return current;
    }
    //--------------------------------------------
    public void Push(int value)
    {
        var newStart = new Element
        {
            Next = _first,
            Value = value
        };
        _first = newStart;
        CountStack++;
    }
    public int Pop()
    {
        var deletedValue = _first.Value;
        if (CountStack > 1)
        {
            _first = _first.Next;
            CountStack--;
        }
        return deletedValue;
    }
    public int Peek()
    {
        var firstChild = _first.Value;
        return firstChild;
    }
}