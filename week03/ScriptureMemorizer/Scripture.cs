using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Scriptures
{
    private List<References> references = new List<References>();
    private List<Words> words = new List<Words>();

    public Scriptures(List<References> references, List<Words> words)
    {
        this.references = references;
        this.words = words;

    }
    public void AddReference(References reference)
    {
        references.Add(reference);
    }
    public void AddWord(Words word)
    {
        words.Add(word);
    }

    public void HideRandomWords()
    {
        while (true)
        { 
        List<int> visibleWords = new List<int>();
        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].HiddenOrShown())
            {
                visibleWords.Add(i);
            }
        }

        if (visibleWords.Count == 0)
        {
            Console.WriteLine("All words are hidden");
            break;
        }
        
        Random randm = new Random();
        int randomIndex = visibleWords[randm.Next(visibleWords.Count)];
        words[randomIndex].Toggling();
        ShowScripture();
        Console.WriteLine("Press Enter to hide another word");
        Console.ReadLine();
    }
    }
        

    public void ShowScripture()
    {
    foreach (var word in words)
    {
        Console.Write(word.GetText() + " ");
    }
    Console.WriteLine();
    }
}