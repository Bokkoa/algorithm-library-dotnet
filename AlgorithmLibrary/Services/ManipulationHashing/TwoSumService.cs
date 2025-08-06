using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Entities;

namespace AlgorithmLibrary.Services.ManipulationHashing;

public class TwoSumService : ITwoSumService
{
    public Task<Dictionary<string, int[]>> demostrate()
    {

        Dictionary<string, int[]> results = new Dictionary<string, int[]>();
        TwoSumEntity entity = new TwoSumEntity();

        // test 1
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] res1 = entity.Execute(nums1, target1);
        results.Add($"Target {target1}, nums: {string.Join("", nums1)}", res1);

        //// test 2
        int[] nums2 = { 3, 3 };
        int target2 = 6;
        int[] res2 = entity.Execute(nums2, target2);
        results.Add($"Target {target2}, nums: {string.Join("", nums2)}", res2);

        //// test 3
        int[] nums3 = { 3, 1, 7, 9, 2, 4 };
        int target3 = 6;
        int[] res3 = entity.Execute(nums3, target3);
        results.Add($"Target {target3}, nums: {string.Join("", nums3)}", res3);


        return Task.FromResult(results);
    }
}
