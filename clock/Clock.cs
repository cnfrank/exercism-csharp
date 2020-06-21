using System;
// using System.Collections.Generic;

// public class Clock : IEquatable<Clock>
// {
//     public int Hours;  
//     public int Minutes;

//     public Clock(int hours, int minutes)
//     {
//         // throw new NotImplementedException("You need to implement this function.");
//         this.Minutes = minutes % 60;
        
//         this.Hours = (hours + minutes / 60) % 24;
       
//     }

//     public bool Equals(Clock other)
//     {
//         if (other == null) return false;
        
//        // return (this.Minutes.Equals(other.Minutes % 60) && this.Hours.Equals( (other.Minutes / 60 + other.Hours) % 24));

//         return (this.Minutes.Equals(other.Minutes) && this.Hours.Equals(other.Hours));
//     }

//     public override bool Equals(object obj)
//     {
//         return base.Equals(obj);
//     }

//     public override int GetHashCode()
//     {
//         return base.GetHashCode();
//     }
    
//     public override string ToString() => $"{this.Hours:D2}:{this.Minutes:D2}";
    
//     // public override string ToString() => $"{this.Hours:D2}:{this.Minutes:D2}";

//     public Clock Add(int minutesToAdd)
//     {
//         throw new NotImplementedException("You need to implement this function.");
//     }

//     public Clock Subtract(int minutesToSubtract)
//     {
//         throw new NotImplementedException("You need to implement this function.");
//     }

    
// }

public struct Clock
{
    private const int MinutesPerHour = 60; // 设定常量 每小时60分钟
    private const int MinutesPerDay = 1440; // 设定常量 每天1440分钟

    private readonly int _minutes;

    public Clock(int hours, int minutes = 0) => _minutes = Mod(hours * MinutesPerHour + minutes, MinutesPerDay);

    public Clock Add(int minutes) => new Clock(Hours, Minutes + minutes);

    public Clock Subtract(int minutes) => new Clock(Hours, Minutes - minutes);

    public override string ToString() => $"{Hours:00}:{Minutes:00}";

    public int Hours => _minutes / MinutesPerHour;

    public int Minutes => _minutes % MinutesPerHour;

    private static int Mod(int x, int y) => (int)((x % y + y) % y);
}
