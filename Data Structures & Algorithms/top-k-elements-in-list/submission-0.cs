public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freqs = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {

            if(!freqs.ContainsKey(nums[i]))
            {
                freqs[nums[i]] = 1;
            }
            else
            {
                freqs[nums[i]]++;
            }
        
        }

        int[] res = new int [k];

        for(int i = 0; i < k; i++)
        {
            int highFreq = freqs.Values.Max();
            
            int key = 0;
            foreach(var item in freqs)
            {
                if(item.Value == highFreq)
                {
                    key = item.Key;
                    break;
                }
            }
            res[i] = key;
            freqs.Remove(key);
            
        }

        return res;
        
    }
}
