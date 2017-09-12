namespace TestTask.Logic.Interfaces
{
    interface ISentence
    {
        void AddWord(IWord word);
        void ReplaceChar(int k, char symbol);
    }
}