using AlgorithmLibrary.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmLibrary.Controllers;
[Route("api/manipulation-n-hashing")]
[ApiController]
public class ManipulationHashingController : ControllerBase
{

    private readonly ITwoSumService _TwoSumService;
    private readonly IContainsDuplicateService _ContainsDuplicateService;
    private readonly IValidAnagramService _ValidAnagramService;
    private readonly IGroupAnagramsService _GroupAnagramService;
    private readonly ITopKFrequentElementsService _TopKFrequentElementsService;
    private readonly IIsSubsequenceService _IsSubsequenceService;
    private readonly ILongestConsecutiveSequenceService _LongestConsecutiveSequenceService;
    public ManipulationHashingController(
        ITwoSumService twoSumService,
        IContainsDuplicateService containsDuplicateService,
        IValidAnagramService validAnagramService,
        IGroupAnagramsService groupAnagramService,
        ITopKFrequentElementsService topKFrequentElementsService,
        IIsSubsequenceService isSubsequenceService,
        ILongestConsecutiveSequenceService longestConsecutiveSequenceService)
    {
        _TwoSumService = twoSumService;
        _ContainsDuplicateService = containsDuplicateService;
        _ValidAnagramService = validAnagramService;
        _GroupAnagramService = groupAnagramService;
        _TopKFrequentElementsService = topKFrequentElementsService;
        _IsSubsequenceService = isSubsequenceService;
        _LongestConsecutiveSequenceService = longestConsecutiveSequenceService;
    }

    [HttpGet("twosum")]
    public async Task<Dictionary<string, int[]>> TwoSum()
    {
        var result = await _TwoSumService.demostrate();
        return result;
    }

    [HttpGet("contains-duplicate")]
    public async Task<Dictionary<string, bool>> ContainsDuplicate()
    {
        var result = await _ContainsDuplicateService.demonstrate();
        return result;
    }

    [HttpGet("valid-anagram")]
    public async Task<Dictionary<string, bool>> ValidAnagram()
    {
        return await _ValidAnagramService.demonstrate();
    }

    [HttpGet("group-anagram")]
    public async Task<Dictionary<string, IList<IList<string>>> > GroupAnagram()
    {
        return await _GroupAnagramService.demonstrate();
    }

    [HttpGet("top-k-frequent-elements")]
    public async Task<Dictionary<string, int>> TopKFrequentElements()
    {
        return await _TopKFrequentElementsService.demonstrate();
    }

    [HttpGet("is-subsequence")]
    public async Task<Dictionary<string, bool>> IsSubsequence()
    {
        return await _IsSubsequenceService.demonstrate();
    }


    [HttpGet("longest-consecutive-sequence")]
    public async Task<Dictionary<string, int>> LongestConsecutiveSequence()
    {
        return await _LongestConsecutiveSequenceService.demonstrate();
    }


}
