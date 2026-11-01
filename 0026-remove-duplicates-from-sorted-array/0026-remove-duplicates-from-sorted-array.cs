public class Solution {
   public  int RemoveDuplicates(int[] nums)
{
    if (nums == null) return 0;

    if (nums.Length == 1) return 1;
   
        int currnt = 1, beforecurrent = 1;

        while (beforecurrent < nums.Length)
        {
            if (nums[beforecurrent] != nums[beforecurrent - 1])
            {
                nums[currnt] = nums[beforecurrent];
                currnt++;

            }

            beforecurrent++;

        }

    return currnt;
}
}