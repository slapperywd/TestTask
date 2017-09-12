using System.Collections.Generic;
using System.Text;
using TestTask.Logic.Interfaces;

namespace TestTask.Logic.Classes
{
    class Sentence:ISentence
    {
        private List<IWord> words;

        public Sentence()
        {
            words = new List<IWord>();
        }

        public void AddWord(IWord word)
        {
            words.Add(word);
        }

        public void ReplaceChar(int k, char symbol)
        {
            StringBuilder sb;

            foreach (var word in words)
            {
                if (word.Text.Length < k) continue;

                sb = new StringBuilder(word.Text);
                sb[k-1] = symbol;
                word.Text = sb.ToString();
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var word in words)
            {
                result += word.Text + " ";
            }
            return result;
        }
    }
}
