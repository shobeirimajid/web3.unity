namespace ChainSafe.Gaming.Evm.HDNode.Wordlists
{
    public abstract class Wordlist
    {
        protected Wordlist(string local)
        {
            Local = local;
        }

        public string Local { get; }

        public abstract string GetWord(int index);

        public abstract int GetWordIndex(string word);
    }
}