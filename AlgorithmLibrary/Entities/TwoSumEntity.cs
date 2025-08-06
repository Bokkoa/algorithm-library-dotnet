namespace AlgorithmLibrary.Entities;

public class TwoSumEntity
{

    public TwoSumEntity() {}

    public int[] Execute(int[] nums, int target)
    {
        // store the index and the result
        // map index is equals to the substraction of current index to the target
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {

            // check if a number of index is equal to the previous substraction
            if (map.TryGetValue(nums[i], out int index)){


                return [index, i];
            }

            int substraction = target - nums[i];
            map.TryAdd(substraction, i);
        }

        return [0, 0];
    }
}
