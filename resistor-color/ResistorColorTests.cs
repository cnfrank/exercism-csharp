// This file was auto-generated based on version 1.0.0 of the canonical data.

using Xunit;

public class ResistorColorTests
{
    [Fact]
    public void Black()
    {
        Assert.Equal(0, ResistorColor.ColorCode("black"));
    }

    [Fact]
    public void White()
    {
        Assert.Equal(9, ResistorColor.ColorCode("white"));
    }

    [Fact]
    public void Orange()
    {
        Assert.Equal(3, ResistorColor.ColorCode("orange"));
    }

    [Fact]
    public void Colors()
    {
        Assert.Equal(new[] { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Grey", "White" }, ResistorColor.Colors());
    }
}