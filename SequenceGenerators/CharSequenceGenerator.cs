using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceGenerators;

public class CharSequenceGenerator : SequenceGenerator<char>
{
    public CharSequenceGenerator(char firstValue = 'A', char secondValue = 'B') : base(firstValue, secondValue)
    {
    }

    protected override char GetNext()
    {
        return (char)((Previous + Current) % 128);  // Using modulo to keep within ASCII range
    }
}
