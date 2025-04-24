namespace SequenceGenerators;

public class DoubleSequenceGenerator : SequenceGenerator<double>
{
    public DoubleSequenceGenerator() : base(1.0, 2.0)
    {
    }

    protected override double GetNext()
    {
        return Current + Previous / Current;
    }
} 