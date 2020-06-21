using System;

public class SpaceAge
{
    public double secondsSA { get; set; }

    public const double ORBITAL_PERIOD_EARTH_SECONDS = 31557600.00;
    public const double ORBITAL_PERIOD_EARTH_DAYS = 365.25;
    public const double ORBITAL_PERIOD_RATIO_MERCURY = 0.2408467;
    public const double ORBITAL_PERIOD_RATIO_VENUS = 0.61519726;
    public const double ORBITAL_PERIOD_RATIO_MARS = 1.8808158;
    public const double ORBITAL_PERIOD_RATIO_JUPITER = 11.862615;
    public const double ORBITAL_PERIOD_RATIO_SATURN = 29.447498;
    public const double ORBITAL_PERIOD_RATIO_URANUS = 84.016846;
    public const double ORBITAL_PERIOD_RATIO_NEPTUNE = 164.79132;
    public SpaceAge(int seconds)
    {
        secondsSA = seconds;
    }

    public double OnEarth()
    {
         return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS;
    }

    public double OnMercury()
    {
        
        return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS / ORBITAL_PERIOD_RATIO_MERCURY ;
    }

    public double OnVenus()
    {
        
         return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS / ORBITAL_PERIOD_RATIO_VENUS;
    }

    public double OnMars()
    {
        
         return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS / ORBITAL_PERIOD_RATIO_MARS;
    }

    public double OnJupiter()
    {
        
         return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS / ORBITAL_PERIOD_RATIO_JUPITER;
    }

    public double OnSaturn()
    {
        
         return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS / ORBITAL_PERIOD_RATIO_SATURN;
    }

    public double OnUranus()
    {
        
         return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS / ORBITAL_PERIOD_RATIO_URANUS;
    }

    public double OnNeptune()
    {
        
         return secondsSA / ORBITAL_PERIOD_EARTH_SECONDS / ORBITAL_PERIOD_RATIO_NEPTUNE;
    }
}