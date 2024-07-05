using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    public string Book { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int startVerse)
    {
        Book = book;
        StartVerse = startVerse;
    }

    public Reference(string book, int startVerse, int endVerse)
    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{Book} {StartVerse}-{EndVerse}" : $"{Book} {StartVerse}";
    }
}