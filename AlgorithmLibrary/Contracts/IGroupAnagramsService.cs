namespace AlgorithmLibrary.Contracts;

public interface IGroupAnagramsService
{
    public Task<Dictionary<string, IList<IList<string>>>> demonstrate();
}
