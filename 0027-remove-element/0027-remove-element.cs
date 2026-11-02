public class Solution {
    public  int RemoveElement(int[] nums, int val)
{
    if(nums == null ) return -1;
    
    int counter = 0 , index = 0;

    while (index < nums.Length)
    {
        if (nums[index] != val)
        {
            nums[counter] = nums[index];
            counter++;
            
        }
        index++;
    }
    return counter;

}
}