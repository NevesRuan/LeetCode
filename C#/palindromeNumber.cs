/*
    LeetCode day 02 - C#
    
    9. Palindrome Number
    https://leetcode.com/problems/palindrome-number/
    https://leetcode.com/problems/palindrome-number/submissions/2189712578/

    Given an integer x, return true if x is a palindrome, and false otherwise.

    Example 1:
    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.

    Example 2:
    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

*/

public class Solution {
    public bool IsPalindrome(int x) {
        String numbers = x.ToString();
        IEnumerable<char> enumreverseNumbers = numbers.Reverse();
        String reverseNumbers = new String(enumreverseNumbers.ToArray());

        if (numbers == reverseNumbers){
            return true;
        }
        else return false;
    }
}