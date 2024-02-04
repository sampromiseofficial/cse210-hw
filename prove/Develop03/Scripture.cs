using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        public string Reference { get; set; }
        public string Text { get; set; }

        public List<Word> Words { get; set; }

        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
            InitializeWords();
        }

        private void InitializeWords()
        {
            string[] textWords = Text.Split(' ');
            Words = new List<Word>();
            foreach (var word in textWords)
            {
                Words.Add(new Word(word));
            }
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, Words.Count);
            Words[index].IsVisible = false;
        }

        public bool AllWordsHidden()
        {
            foreach (var word in Words)
            {
                if (word.IsVisible)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string visibleText = "";
            foreach (var word in Words)
            {
                visibleText += (word.IsVisible) ? word.Text + " " : "----- ";
            }
            return $"{Reference}: {visibleText}";
        }
    }
}
