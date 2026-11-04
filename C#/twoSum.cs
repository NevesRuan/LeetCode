/*
    LeetCode day 01 - C#
    
    1. Two Sum
    https://leetcode.com/problems/two-sum/
    https://leetcode.com/problems/two-sum/submissions/2188999293/

        You are given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.

        Example 1:
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]

        Explanation:
        The sum of nums[0] and nums[1] is 2 + 7 = 9, which equals the target. Therefore, the indices [0, 1] are returned.

*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            int[] final;
             for (int a = 0; a < nums.Count(); a++){
                for (int b = a+1; b < nums.Count(); b++){
                    if (nums[a] + nums[b] == target){
                        return final = new int[2] {a,b};
                    }
                }
            }
            return new int[0];
        }
    }