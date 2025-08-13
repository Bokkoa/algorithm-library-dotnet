using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Entities;

namespace AlgorithmLibrary.Services.ManipulationHashing;

public class IsSubsequenceService : IIsSubsequenceService
{
    public Task<Dictionary<string, bool>> demonstrate()
    {

        Dictionary<string, bool> result = new Dictionary<string, bool>();

        IsSubsequenceEntity entity = new IsSubsequenceEntity();

        string s1 = "abc";
        string t1 = "ahbgdc";
        bool res1 = entity.Execute(s1, t1);

        result.Add($"sequence: {s1}  subsequence: {t1}", res1);

        string s2 = "axc";
        string t2 = "ahbgdc";
        bool res2 = entity.Execute(s2, t2);
        result.Add($"sequence: {s2}  subsequence: {t2}", res2);

        return Task.FromResult(result);
    }
}
