using System;
using System.Collections.Generic;

public class Solution
{

    public static void Main(string[] args)
    {
        Console.WriteLine("CheckSubarraySum");
    }

    public bool CheckSubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> modDict = new Dictionary<int, int>();
        modDict[0] = -1;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            int mod = sum % k;

            if (mod < 0)
                mod += k;

            if (modDict.ContainsKey(mod))
            {
                if (i - modDict[mod] > 1)
                    return true;
            }
            else
                modDict[mod] = i;
        }

        return false;
    }
}
