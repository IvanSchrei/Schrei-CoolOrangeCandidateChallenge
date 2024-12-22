using System;

namespace rekursion
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string input){
            //If string has 1 or 0 characters it's automatically a palindrome
            if(input.Length <= 1){
                return true;
            }

            //cecking if first and last character match, if they don't return false
            if(input[0] != input[input.Length - 1]){
                return false;
            }

            //calling method again with shortened string, so cut away first and last character, this part makes the method recursive
            return IsPalindrome(input.Substring(1, input.Length - 2));
        }
    }
}
