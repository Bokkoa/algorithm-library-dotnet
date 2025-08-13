namespace AlgorithmLibrary.Entities;

public class IsSubsequenceEntity
{
    public bool Execute(string s, string t)
    {
        if (s.Length <= 0 ) return true;
        if(s.Length > t.Length) return false;

        int charsLeft = s.Length;
        int currentCharValidated = 0;

        for (int i = 0; i < t.Length; i++)
        {

            if (s[currentCharValidated] == t[i]) { 
                currentCharValidated++;
                charsLeft--;
                if (charsLeft == 0) return true;
            }
        }


        return false;
    }

    public bool ExecuteFirstApproach(string s, string t) {

        if (s.Length <= 0) return true;
        if (s.Length > t.Length) return false;
        Stack<string> stack = new Stack<string>();

        // mappign dictionary
        for (int i = s.Length - 1; i >= 0; i--)
        {
            stack.Push(s[i].ToString());
        }

        string a = stack.First();

        for (int i = 0; i < t.Length; i++)
        {

            if (stack.First() == t[i].ToString())
            {
                stack.Pop();

                if (stack.Count == 0) return true;
            }
        }


        return false;
    }
}
