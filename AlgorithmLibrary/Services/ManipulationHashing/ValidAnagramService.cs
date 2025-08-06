using AlgorithmLibrary.Contracts;
using AlgorithmLibrary.Entities;

namespace AlgorithmLibrary.Services.ManipulationHashing;

public class ValidAnagramService : IValidAnagramService
{
    public Task<Dictionary<string, bool>> demonstrate()
    {
        Dictionary<string, bool> results = new Dictionary<string, bool>();
        ValidAnagramEntity entity = new ValidAnagramEntity();

        // test 1
        string s1 = "anagram";
        string t1 = "nagaram";

        bool res1 = entity.Execute(s1, t1);
        results.Add($"s1 {s1}, t1: {t1}", res1);

        //// test 2
        string s2 = "state";
        string t2 = "tea";

        bool res2 = entity.Execute(s2, t2);
        results.Add($"s2 {s2}, t2: {t2}", res2);

        //// test 3
        string s3 = "school master";
        string t3 = "the classroom";

        bool res3 = entity.Execute(s3, t3);
        results.Add($"s3 {s3}, t3: {t3}", res3);

        return Task.FromResult(results);
    }
}
