using Xunit;

public class testclass{
    [Fact]
    public void PassingTest(){
        Assert.Equal(4, Calc.Add(2,2));
    }
}