namespace ScriptureMemorizer
{
    public class Word
    {
        public string Text { get; set; }
        public bool IsVisible { get; set; }

        public Word(string text)
        {
            Text = text;
            IsVisible = true;
        }
    }
}
