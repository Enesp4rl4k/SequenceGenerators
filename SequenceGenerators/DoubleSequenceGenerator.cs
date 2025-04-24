using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
