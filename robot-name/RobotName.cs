using System;
using System.Collections.Generic;

public class Robot
{
    // star up constructor
    public Robot()
    {
        this.Reset();
    }

    // support private set only; 
    public string Name { get; private set; }

    public void Reset()
    {
        string oldName = Name;
        Name = TakenNames.NewName();
        TakenNames.Remove(oldName);
    }
}

internal static class TakenNames
{
    private static Random rnd = new Random();
    private static HashSet<string> botNames = new HashSet<string>();

    public static void Remove(string name)
    {
        botNames.Remove(name);
    }

    public static string NewName()
    {
        string name = GenerateName();
        while (!botNames.Add(name))
            name = GenerateName();
        return name;
    }

    private static string GenerateName()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        // return $"{chars[(new Random()).Next(1,24)]}{chars[(new Random()).Next(1,24)]}{(new Random()).Next(100,999)}";
        return string.Concat(chars[(new Random()).Next(1,24)],chars[(new Random()).Next(1,24)],(new Random()).Next(100,999));

    }
}