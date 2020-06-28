using System;
using System.Collections.Generic;
using System.Linq;

public static class Strain
{
    static bool predFunction(T)
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // return collection.Where(x => predicate(x));

        // The traditional way of doing it
        foreach(var item in collection)
		{
			if(predicate(item)) yield return item;
		}

        
            


    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        // throw new NotImplementedException("You need to implement this function.");
        return collection.Where(x => !predicate(x));
    }
}