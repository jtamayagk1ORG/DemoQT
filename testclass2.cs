using System;
using Xunit;
using CompassNamespace;

public class testclass2
{
	[Fact]
	public void PassingTest5()
	{
		Assert.Equal("Only cardinal directions", Compass.Directions(26));
	}

	[Fact]
	public void PassingTest6()
	{
		Assert.Equal("West", Compass.Directions(270));
	}
}