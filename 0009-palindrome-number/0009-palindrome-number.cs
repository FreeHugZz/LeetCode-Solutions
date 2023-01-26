public class Solution {
    public bool IsPalindrome(int x) {
       char[] charArr = x.ToString().ToCharArray(); 
       
            char[] reverseArr = x.ToString().ToCharArray();

            Array.Reverse(reverseArr);

            return charArr.SequenceEqual(reverseArr); 
    }
}