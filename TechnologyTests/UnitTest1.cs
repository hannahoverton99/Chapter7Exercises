using Chapter7Exercises;


namespace TechnologyTests;

[TestClass]
public class TechnologyTests
{
    [TestMethod]
    public void TestIncreasingRam()
    {
        Computer testingComputer= new Computer(2, 3, true);
        testingComputer.IncreaseRam(3);
        Assert.AreEqual(2, testingComputer.Ram);
        Assert.AreEqual(5, testingComputer.Ram);
    }
}