using System;
using TestTask.Logic.Interfaces;

namespace TestTask.Logic.Classes
{
    class SentenceBuilder
    {
        private ISentence _sentence;
        public SentenceBuilder(ISentence sentence, string inputStr)
        {
            _sentence = sentence;
            ParseInput(inputStr);
        }

        private void ParseInput(string inputStr)
        {
            string[] splittedStr = inputStr.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splittedStr.Length; i++)
            {
                _sentence.AddWord(new Word { Text = splittedStr[i] });
            }
        }

        public void ReplaceChar(int k, char symbol)
        {
            _sentence.ReplaceChar(k, symbol);
        }

        public override string ToString()
        {
            return _sentence.ToString();
        }


    }
}
