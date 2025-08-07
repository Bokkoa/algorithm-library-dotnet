namespace AlgorithmLibrary.Entities;

public class ValidAnagramEntity
{
    public bool Execute(string s, string t)
    {

        s = s.ToLower();
        t = t.ToLower();

        s.Replace(" ", "");
        t.Replace(" ", "");

        int[] array = new int[26];

        foreach(char subS in s)
        {
            int asciiValue = subS;
            array[asciiValue - (int)'a'] += 1;
        }

        foreach (char subT in t)
        {
            int asciiValue = subT;
            array[asciiValue - (int)'a'] -= 1;
        }

        foreach (int letter in array) {
            if (letter != 0) return false;
        }

        return true;
    }

    public bool ProposalExecution(string s, string t)
    {
        // Is not a valid anagram if is not using ALL the original letters exactly once.
        if (s.Length != t.Length) return false;

        // collect each repetition for the two strings once we have the same lenght
        Dictionary<string, int> sDict = new Dictionary<string, int>();
        Dictionary<string, int> tDict = new Dictionary<string, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (sDict.ContainsKey($"{s[i]}"))
            {
                sDict[$"{s[i]}"] = sDict[$"{s[i]}"] + 1;
            }
            else
            {
                sDict[$"{s[i]}"] = 1;
            }



            if (tDict.ContainsKey($"{t[i]}"))
            {
                tDict[$"{t[i]}"] = tDict[$"{t[i]}"] + 1;
            }
            else
            {
                tDict[$"{t[i]}"] = 1;
            }

        }

        // comparing dictionaries values
        foreach (string subS in sDict.Keys)
        {
            if (!tDict.ContainsKey(subS)) return false;

            if (tDict[subS] != sDict[subS]) return false;

        }

        return true;
    }
}
