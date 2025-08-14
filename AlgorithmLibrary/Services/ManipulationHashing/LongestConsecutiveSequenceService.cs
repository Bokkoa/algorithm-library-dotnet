using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Entities;

namespace AlgorithmLibrary.Services.ManipulationHashing;

public class LongestConsecutiveSequenceService : ILongestConsecutiveSequenceService
{
    public Task<Dictionary<string, int>> demonstrate()
    {
        int[] nums1 = { 100, 4, 200, 1, 3, 2 };
        int[] nums2 = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
        int[] nums3 = { 1, 0, 1, 2 };

        LongestConsecutiveSequenceEntity entity = new LongestConsecutiveSequenceEntity();

        int res1 = entity.Execute(nums1);
        int res2 = entity.Execute(nums2);
        int res3 = entity.Execute(nums3);


        var result = new Dictionary<string, int>();

        result.Add(String.Join(", ", nums1), res1);
        result.Add(String.Join(", ", nums2), res2);
        result.Add(String.Join(", ", nums3), res3);

        return Task.FromResult(result);
    }
}
