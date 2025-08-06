namespace AlgorithmLibrary.Contracts;

public interface IContainsDuplicateService
{
    public Task<Dictionary<string, bool>> demonstrate();
}
