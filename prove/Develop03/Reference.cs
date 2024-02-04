using System;

namespace ScriptureMemorizer
{
    public class Reference
    {
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int VerseFrom { get; set; }
        public int VerseTo { get; set; }

        public Reference(string book, int chapter, int verseFrom, int verseTo)
        {
            Book = book;
            Chapter = chapter;
            VerseFrom = verseFrom;
            VerseTo = verseTo;
        }

        public override string ToString()
        {
            if (VerseFrom == VerseTo)
            {
                return $"{Book} {Chapter}:{VerseFrom}";
            }
            else
            {
                return $"{Book} {Chapter}:{VerseFrom}-{VerseTo}";
            }
        }
    }
}
