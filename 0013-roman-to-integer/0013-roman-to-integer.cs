public class Solution {
    public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int sum = 0;
            int last = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int current = map[s[i]];
                if (current < last)
                {
                    sum -= current;
                }
                else
                {
                    sum += current;
                }
                last = current;
            }
            return sum;
        }
}