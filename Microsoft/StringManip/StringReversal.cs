using System;

namespace StringManip
{
    public class StringReversal
    {
        string _input = null;
        string _reversedInput = null;

        public StringReversal(string input)
        {
            _input = input;
        }

        public void PerformReversal()
        {
            string holder = "";

            for(int i = _input.Length-1; i >= 0; i--)
            {
                holder += _input[i];
            }

            _reversedInput = holder;
        }

        public string GetUserInput()
        {
            return _input;
        }

        public string GetReversedInput()
        {
            if(_reversedInput == null)
            {
                return "Please PerformReversal() first";
            }
            else
            {
                return _reversedInput;
            }
        }

        public bool IsPalindrome()
        {
            if(_input.Equals(_reversedInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}