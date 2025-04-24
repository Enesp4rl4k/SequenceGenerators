namespace SequenceGenerators;

public class IntegerSequenceGenerator : SequenceGenerator<int>
{
    public IntegerSequenceGenerator() : base(1, 2)
    {
    }

    protected override int GetNext()
    {
        return 6 * Current - 8 * Previous;
    }
} 