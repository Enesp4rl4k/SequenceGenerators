namespace SequenceGenerators;

public delegate T SequenceRule<T>(T current, T previous);

public class DelegateSequenceGenerator<T> : SequenceGenerator<T>
{
    private readonly SequenceRule<T> _generationRule;

    public DelegateSequenceGenerator(T firstValue, T secondValue, SequenceRule<T> rule) 
        : base(firstValue, secondValue)
    {
        _generationRule = rule ?? throw new ArgumentNullException(nameof(rule));
    }

    protected override T GetNext()
    {
        return _generationRule(Current, Previous);
    }
} 