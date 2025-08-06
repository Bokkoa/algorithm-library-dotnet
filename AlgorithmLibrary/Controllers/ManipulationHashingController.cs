using AlgorithmLibrary.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmLibrary.Controllers;
[Route("api/manipulation-n-hashing")]
[ApiController]
public class ManipulationHashingController : ControllerBase
{

    private readonly ITwoSumService _TwoSumService;
    private readonly IContainsDuplicateService _ContainsDuplicateService;

    public ManipulationHashingController(ITwoSumService twoSumService, IContainsDuplicateService containsDuplicateService)
    {
        _TwoSumService = twoSumService;
        _ContainsDuplicateService = containsDuplicateService;
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
}
