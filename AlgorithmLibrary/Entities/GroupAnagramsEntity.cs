namespace AlgorithmLibrary.Entities;

public class GroupAnagramsEntity
{
    public IList<IList<string>> execute(string[] strs)
    {
        IList<IList<string>> groups = new List<IList<string>>();

        Dictionary<string, List<string>> sortStringsDict = new Dictionary<string, List<string>>();


        // interate over strings
        for(int i = 0; i < strs.Length; i++)
        {
            // sort strings to use it as index
            string sortedString = String.Concat( strs[i].OrderBy(c => c));
            
            // looking for sorted string index in dict
            if (sortStringsDict.ContainsKey(sortedString))
            {
                // pushing index in case that sort string already exists
                sortStringsDict[sortedString].Add(strs[i]);
            } else
            {
                // create new list of indexes in case not
                sortStringsDict.Add(sortedString, new List<string> { strs[i] });
            }
        }

       
        foreach (List<string> group in sortStringsDict.Values)
        {
            groups.Add(group);
        }
    

        return groups;
    }

    public IList<IList<string>> executeUsingFrequencyPattern(string[] strs) {
        if (strs.Length == 0) return [];
        Dictionary<string, List<string>> hashMap = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            string frequencyString = this.getFrequencyString(str);

            if (!hashMap.ContainsKey(frequencyString))
            {
                hashMap[frequencyString] = new List<string>();
            }
            hashMap[frequencyString].Add(str);
        }


        return hashMap.Values.Select(val => (IList<string>)val).ToList();
        
    }

    public string getFrequencyString(string strToEvaluate)
    {
        int[] frequencyList = new int [26];

        foreach(char str in strToEvaluate)
        {
            frequencyList[(int)str - (int)'a'] += 1;
        }

        var frequencyString = new List<string>();

        char letter = 'a';

        foreach(int position in frequencyList)
        {
            frequencyString.Add(letter.ToString());
            frequencyString.Add(position.ToString());
            
            letter = (char)(((int)letter )+ 1);
        }

        return String.Join("", frequencyString.ToArray());
    }

}
