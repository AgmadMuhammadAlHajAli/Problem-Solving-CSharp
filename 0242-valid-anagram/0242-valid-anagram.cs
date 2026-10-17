public class Solution {
     public bool IsAnagram(string s, string t)
{  
    if (s.Length != t.Length)
    {  
        return false; 
    }
    Dictionary<char, int> countsS = new Dictionary<char, int>();
    Dictionary<char, int> countsT = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (countsS.ContainsKey(s[i]))
            {
                countsS[s[i]]++;
                
            }
            else
            {
                countsS[s[i]] = 1;
            }
            if (countsT.ContainsKey(t[i]))
            {
                countsT[t[i]]++;

            }
            else
            {
                countsT[t[i]] = 1;
            }
        }
        foreach (var count in countsS)
        {
            char key = count.Key;
            int value = count.Value;

            if(!countsT.ContainsKey(key) || countsT[key] != value)
            {
                return false;
            }
        }
        return true;
}
}
