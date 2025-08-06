using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Entities;

namespace AlgorithmLibrary.Services.ManipulationHashing;

public class ContainsDuplicateService : IContainsDuplicateService
{
    public Task<Dictionary<string, bool>> demonstrate(int[] nums)
    {
        Dictionary<string, bool> results = new Dictionary<string, bool>();
        ContainsDuplicateEntity entity = new ContainsDuplicateEntity();

        int[] nums1 = { 1, 2, 3, 1, 5 };
        int[] nums2 = { 5, 2, 7, 8, 9, 6, 7 };
        int[] nums3 = { 1,2, 3, 4, 5, 6, 7 };


        bool res1 = entity.execute(nums1);
        bool res2 = entity.execute(nums2);
        bool res3 = entity.execute(nums3);

        results.Add($"{string.Join("", nums1)}", res1);
        results.Add($"{string.Join("", nums2)}", res2);
        results.Add($"{string.Join("", nums3)}", res3);
        
        return Task.FromResult(results);
    }
}
