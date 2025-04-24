using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceGenerators
{
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
}
