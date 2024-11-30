public class Reference
{
    public string Book { get; private set; }
    public string Chapter { get; private set; }
    public string VerseStart { get; private set; }
    public string VerseEnd { get; private set; }

    public Reference(string book, string chapter, string verseStart, string verseEnd = null)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public override string ToString()
    {
        return VerseEnd == null
            ? $"{Book} {Chapter}:{VerseStart}"
            : $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
    }
}
