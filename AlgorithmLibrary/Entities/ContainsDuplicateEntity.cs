namespace AlgorithmLibrary.Entities;

public class ContainsDuplicateEntity
{
    public bool execute(int[] nums)
    {
        // Is preferable to use a hashset instead of dictionary
        //Dictionary<int, bool> history = new Dictionary<int, bool>();
        HashSet<int> result = new HashSet<int>();

        foreach(int i in nums)
        {
            if (result.Contains(i))
            {
                return true;
            } 
            result.Add(i);
        }

        return false;
    }
}
