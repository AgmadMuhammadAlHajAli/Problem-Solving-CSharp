public class Solution {
  public int Search(int[] nums, int target)
 {
     if (nums == null || nums.Length == 0) return -1;

     if (target < nums[0] || target > nums[nums.Length - 1]) return -1;

     int left = 0;
     int right = nums.Length - 1;

     while (left <= right)
     {
         int mid = left + (right - left) / 2;

         if (nums[mid] == target)
         {
             return mid; 
         }
         else if (target > nums[mid])
         {
             left = mid + 1;
         }
         else
         {
             right = mid - 1;
         }
     }

     return -1;
 }
}