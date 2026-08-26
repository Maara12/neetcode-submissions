public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        Dictionary<char,int> charFreq = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++)
        {
            if(charFreq.ContainsKey(s[i]))
            {
                charFreq[s[i]]++;
            }
            else
            {
                charFreq[s[i]] = 1;
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if(!charFreq.ContainsKey(t[i]))
                return false;
            else
            {
                charFreq[t[i]]--;
                if(charFreq[t[i]] == 0)
                {
                    charFreq.Remove(t[i]);
                }
            }
        }

        if(charFreq.Count == 0)
            return true;
        else
            return false;

    }
}
