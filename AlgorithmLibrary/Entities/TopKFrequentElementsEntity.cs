namespace AlgorithmLibrary.Entities;

public class TopKFrequentElementsEntity
{

    public int[] execute(int[] nums, int k)
    {

        Dictionary<int, int> repetitions = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if (!repetitions.ContainsKey(nums[i]))
            {
                repetitions[nums[i]] = 0;
            } 

            repetitions[nums[i]]++;
        }


        var sortedRepetitions = repetitions.OrderByDescending( r => r.Value).ToDictionary<int, int>();

        var array = sortedRepetitions.Keys.Take(k).ToArray();

        return array;
    }
}
