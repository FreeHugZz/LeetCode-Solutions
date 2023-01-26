public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
         if (!strs.Any())
                return string.Empty;


            var shortestWord = strs.MinBy(a => a.Length);
            Console.WriteLine(shortestWord);

            for (int i = 0; i < shortestWord.Length; i++)
            {

                if (strs.Any(a => a[i] != shortestWord[i]))
                    return shortestWord.Substring(0, i);
            }
            return shortestWord;
    }
}