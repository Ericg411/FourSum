namespace FourSum.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 1, 0, -1, 0, -2, 2 };
        int target = 0;

        IList<IList<int>> answer = new List<IList<int>>();
        answer.Add(new List<int>() { -2, -1, 1, 2 });
        answer.Add(new List<int>() { -2, 0, 0, 2 });
        answer.Add(new List<int>() { -1, 0, 0, 1 });

        bool equal = true;

        var result = _test.FourSum(nums, target);

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (result[i][j] != answer[i][j])
                {
                    equal = false;
                }
            }
        }

        Assert.IsTrue(equal);

    }
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 2, 2, 2, 2, 2 };
        int target = 8;

        IList<IList<int>> answer = new List<IList<int>>();
        answer.Add(new List<int>() { 2, 2, 2, 2 });


        bool equal = true;

        var result = _test.FourSum(nums, target);

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (result[i][j] != answer[i][j])
                {
                    equal = false;
                }
            }
        }

        Assert.IsTrue(equal);

    }
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { -3, -1, 0, 2, 4, 5 };
        int target = 1;

        IList<IList<int>> answer = new List<IList<int>>();
        answer.Add(new List<int>() { -3, -1, 0, 5 });


        bool equal = true;

        var result = _test.FourSum(nums, target);

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (result[i][j] != answer[i][j])
                {
                    equal = false;
                }
            }
        }

        Assert.IsTrue(equal);

    }


}