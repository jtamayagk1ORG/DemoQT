using System;
using Xunit;

public class testclass2
{
	[Fact]
	public void PassingTest()
	{
		Assert.Equal("Only cardinal directions", Compass.Direction(124));
	}

	[Fact]
	public void PassingTest2()
	{
		Assert.Equal("West", Compass.Direction(270));
	}
}