using System;
using System.Collections.Generic;
using System.Linq;

public class Hider
{
    private Scripture _scripture;
    private Random _random;

    public Hider(Scripture scripture)
    {
        _scripture = scripture;
        _random = new Random();
    }

    public void HideWords(int minCount, int maxCount)
    {
        var notHiddenWords = _scripture.Words.Where(word => !word.IsHidden).ToList();
        if (!notHiddenWords.Any()) return;

        // Randomly select how many words to hide within the specified range
        int count = _random.Next(minCount, maxCount + 1);
        var toHide = notHiddenWords.OrderBy(x => _random.Next()).Take(Math.Min(count, notHiddenWords.Count));

        foreach (var word in toHide)
        {
            word.Hide();
        }
    }
}
