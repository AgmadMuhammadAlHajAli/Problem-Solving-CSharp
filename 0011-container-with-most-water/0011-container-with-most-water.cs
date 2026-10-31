public class Solution {
 public  int MaxArea(int[] height)
  {
    if (height == null || height.Length < 2) return 0;

    int left = 0 , right = height.Length - 1 , maxArea = 0;
    while (left < right)
    {
        int currentheight = Math.Min(height[left], height[right]);
        int width = right - left;
        int currentArea = currentheight * width;
        maxArea = Math.Max(maxArea, currentArea);

        if(height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return maxArea;
}
}