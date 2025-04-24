namespace SequenceGenerators;

public abstract class SequenceGenerator<T> : ISequenceGenerator<T>
{
    private T _previous;
    private T _current;
    private int _count;

    protected SequenceGenerator(T firstValue, T secondValue)
    {
        _previous = firstValue;
        _current = secondValue;
        _count = 2;
    }

    public T Previous => _previous;
    public T Current => _current;
    public int Count => _count;

    public T Next
    {
        get
        {
            T next = GetNext();
            _previous = _current;
            _current = next;
            _count++;
            return next;
        }
    }

    protected abstract T GetNext();
} 