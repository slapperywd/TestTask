using TestTask.Logic.Interfaces;

namespace TestTask.Logic.Classes
{
    class Word:IWord
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}