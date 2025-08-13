using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Entities;

namespace AlgorithmLibrary.Services.ManipulationHashing;

public class TopKFrequentElementsService : ITopKFrequentElementsService
{
    public Task<Dictionary<string, int>> demonstrate()
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int k = 2;


        int[] nums2 = { 1 };
        int k2 = 1;


        TopKFrequentElementsEntity entity = new TopKFrequentElementsEntity();

        var res = entity.execute(nums, k);

        var res2 = entity.execute(nums2, k2);


        var result = new Dictionary<string, int>
        {
            { $"{String.Join("", res)}", k },
            { $"{String.Join("", res2)}", k2 }
        };

        return Task.FromResult(result);

    }
}
