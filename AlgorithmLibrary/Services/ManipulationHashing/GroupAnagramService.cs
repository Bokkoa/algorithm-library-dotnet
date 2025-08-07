using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Entities;

namespace AlgorithmLibrary.Services.ManipulationHashing;

public class GroupAnagramService : IGroupAnagramsService
{
    public Task<Dictionary<string, IList<IList<string>>>> demonstrate()
    {

        Dictionary<string, IList<IList<string>>> results = new Dictionary<string, IList<IList<string>>>();

        string[] words1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
        string[] words2 = { "" };
        string[] words3 = { "a" };

        GroupAnagramsEntity entity = new GroupAnagramsEntity();

        var res1 = entity.execute(words1);
        var res2 = entity.execute(words2);
        var res3 = entity.execute(words3);

        results.Add(String.Join(" ", words1), res1);
        results.Add(String.Join(" ", words2), res2);
        results.Add(String.Join(" ", words3), res3);


        var res4 = entity.executeUsingFrequencyPattern(words1);
        var res5 = entity.executeUsingFrequencyPattern(words2);
        var res6 = entity.executeUsingFrequencyPattern(words3);

        results.Add("Frequency pattern: " + String.Join(" ", words1), res4);
        results.Add("Frequency pattern: " + String.Join(" ", words2), res5);
        results.Add("Frequency pattern: " + String.Join(" ", words3), res6);

        return Task.FromResult(results);

    }
}
