using Xunit;

public class testclass{
    [Fact]
    public void PassingTest(){
        Assert.Equal(4, Calc.Add(2,2));
    }

    [Fact]
    public void PassingTest2(){
        Assert.Equal(6, Calc.Add(4,2));
    }
}