namespace FourSum;
public class Class1
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        if (nums.Length < 4)
        {
            return result;
        }

        for (long i = 0; i < nums.Length - 1; i++)
        {
            for (long j = i + 1; j < nums.Length; j++)
            {
                long twoSumTarget = nums[i] + nums[j];
                long left = 0;
                long right = nums.Length - 1;

                while (left < right)
                {

                    while (left == i || left == j)
                    {
                        left++;
                    }
                    while (right == i || right == j)
                    {
                        right--;
                    }

                    var sum = nums[left] + nums[right];
                    if (sum + twoSumTarget == target)
                    {
                        IList<int> list = new List<int>() { nums[i], nums[j], nums[left], nums[right] };
                        var orderedList = list.OrderBy(x => x).ToList();

                        if (result.Any(x => x[0] == orderedList[0] && x[1] == orderedList[1] && x[2] == orderedList[2] && x[3] == orderedList[3]))
                        {

                        }
                        else if (i != j && i != left && i != right && j != left && j != right && left != right)
                        {

                            result.Add(orderedList);
                        }
                        var currentLeft = nums[left];
                        while (left < right && nums[left] == currentLeft)
                        {
                            left++;
                        }
                        var currentRight = nums[right];
                        while (left < right && nums[right] == currentRight)
                        {
                            right--;
                        }

                    }
                    else if (sum + twoSumTarget < target)
                    {
                        left++;
                    }
                    else if (sum + twoSumTarget > target)
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
