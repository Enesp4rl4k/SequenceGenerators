namespace SequenceGenerators;

public class FibonacciSequenceGenerator : SequenceGenerator<int>
{
    public FibonacciSequenceGenerator() : base(0, 1)
    {
    }

    protected override int GetNext()
    {
        return Previous + Current;
    }
} 