using System;

namespace Week1.Domain
{
    public class Palindrome
    {
        public bool compare;
        public bool PalindromeFunction(string UserInput)
        {
            for(int i = 0; i < UserInput.Length; i++)
            {
                if (UserInput[i].Equals(UserInput[UserInput.Length - 1 - i]))
                {
                    compare = true;
                }

                else
                {
                    compare = false;
                }
            }

            return compare;
        }
    }
}