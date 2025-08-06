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

    public ManipulationHashingController(
        ITwoSumService twoSumService,
        IContainsDuplicateService containsDuplicateService,
        IValidAnagramService validAnagramService)
    {
        _TwoSumService = twoSumService;
        _ContainsDuplicateService = containsDuplicateService;
        _ValidAnagramService = validAnagramService;
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
}
