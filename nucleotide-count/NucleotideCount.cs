using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        // throw new NotImplementedException("You need to implement this function.");
        if (!sequence.All("ACGT".Contains))
            throw new ArgumentException();

        return (sequence + "ACGT").GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count() - 1);
    }
}