using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool AllWordsHidden => _words.All(word => word.IsHidden);

    public void HideRandomWords(int count = 2)
    {
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();
        var random = new Random();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public override string ToString()
    {
        var words = string.Join(' ', _words);
        return $"{_reference}\n{words}";
    }
}
