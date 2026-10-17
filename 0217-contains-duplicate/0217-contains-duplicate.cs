public class Solution {
    public bool ContainsDuplicate(int[] nums)
{    Dictionary<int,bool> Numbers= new Dictionary<int,bool>();
    for(int i = 0; i < nums.Length; i++)
    {
        if (Numbers.ContainsKey(nums[i]))
        {
            return true;
        }
        Numbers[nums[i]] = true;
    }

    return false;
}
}