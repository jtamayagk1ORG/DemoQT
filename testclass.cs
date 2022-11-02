using System;
using Xunit;
using CalcNamespace;
using CompassNamespace;

public class testclass
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Calc.Add(2,4));
    }

    [Fact]
    public void PassingTest2()
    {
        Assert.Equal(6, Calc.Add(4,2));
    }

    [Fact]
    public void PassingTest3()
    {
        Assert.Equal("North3", Compass.Directions(0));
    }

    [Fact]
    public void PassingTest4()
    {
        Assert.Equal("South", Compass.Directions(180));
    }

    [Fact]
    public void PassingTest5()
    {
        Assert.Equal("South", Compass.Directions(170));
    }
}
