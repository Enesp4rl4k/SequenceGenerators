using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information
namespace SequenceGenerators;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Integer Sequence:");
        var intSequence = new IntegerSequenceGenerator();
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{intSequence.Current}, ");
            intSequence.Next;
        }
        Console.WriteLine("\n");

        Console.WriteLine("Double Sequence:");
        var doubleSequence = new DoubleSequenceGenerator();
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{doubleSequence.Current:F10}, ");
            doubleSequence.Next;
        }
        Console.WriteLine("\n");

        Console.WriteLine("Char Sequence:");
        var charSequence = new CharSequenceGenerator('A', 'B');
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{charSequence.Current}, ");
            charSequence.Next;
        }
        Console.WriteLine("\n");

        Console.WriteLine("Fibonacci Sequence:");
        var fibonacci = new FibonacciSequenceGenerator();
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{fibonacci.Current}, ");
            fibonacci.Next;
        }
        Console.WriteLine("\n");

        // Demonstrating delegate-based sequence generators
        Console.WriteLine("Delegate-based Integer Sequence (same as IntegerSequenceGenerator):");
        var delegateIntSequence = new DelegateSequenceGenerator<int>(1, 2, (current, previous) => 6 * current - 8 * previous);
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{delegateIntSequence.Current}, ");
            delegateIntSequence.Next;
        }
        Console.WriteLine("\n");

        Console.WriteLine("Delegate-based Double Sequence (same as DoubleSequenceGenerator):");
        var delegateDoubleSequence = new DelegateSequenceGenerator<double>(1.0, 2.0, (current, previous) => current + previous / current);
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{delegateDoubleSequence.Current:F10}, ");
            delegateDoubleSequence.Next;
        }
        Console.WriteLine("\n");

        Console.WriteLine("Custom Delegate-based Sequence (Powers of 2):");
        var powerSequence = new DelegateSequenceGenerator<int>(1, 2, (current, _) => current * 2);
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{powerSequence.Current}, ");
            powerSequence.Next;
        }
        Console.WriteLine();
    }
}

