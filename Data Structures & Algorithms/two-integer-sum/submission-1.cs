public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if(map.ContainsKey(complement))
            {
                int[] result = {map[complement],i};
                return result;
            }
            else
            {
                map[nums[i]] = i;
            }
        }

        int[] res = Array.Empty<int>();
        return res;

    }
}
