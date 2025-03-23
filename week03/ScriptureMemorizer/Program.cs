using System;

class Program
{
    static void Main(string[] args)
    {
        References ref1 = new References("John", 3, 16);
        References ref2 = new References("Proverbs", 3, 5, 6);

        Console.WriteLine(ref1.BookChapterVerse());
        Console.WriteLine(ref2.BookChapterStartEndVerse());

        List<Words> wordListJohn = new List<Words>
        { 
        new Words("For"),
        new Words("God"),
        new Words("so"),
        new Words("loved"),
        new Words("the"),
        new Words("world"),
        new Words("that"),
        new Words("he"),
        new Words("gave"),
        new Words("his"),
        new Words("only"),
        new Words("begotten"),
        new Words("Son"),
        new Words("that"),
        new Words("whosoever"),
        new Words("believeth"),
        new Words("in"),
        new Words("him"),
        new Words("should"),
        new Words("not"),
        new Words("perish"),
        new Words("but"),
        new Words("have"),
        new Words("everlasting"),
        new Words("life."),
        };

        List<Words> wordListProverbs = new List<Words>
        {
        new Words("Trust"),
        new Words("in"),
        new Words("the"),
        new Words("Lord"),
        new Words("with"),
        new Words("all"),
        new Words("thine"),
        new Words("heart"),
        new Words("and"),
        new Words("lean"),
        new Words("not"),
        new Words("unto"),
        new Words("thine"),
        new Words("own"),
        new Words("understanding"),
        new Words("in"),
        new Words("all"),
        new Words("thy"),
        new Words("ways"),
        new Words("acknowledge"),
        new Words("him"),
        new Words("and"),
        new Words("he"),
        new Words("shall"),
        new Words("direct"),
        new Words("thy"),
        new Words("paths."),
        };

        Console.WriteLine("Hello we can help you with:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2.Proverbs 3: 5-6");
        Console.Write("What would you like to memorize first?");
        string choice = Console.ReadLine();

        List<References> scriptureference = new List<References>();
        List<Words> scriptureword = new List<Words>();

        if(choice == "1")
        {
            scriptureference.Add(ref1);
            scriptureword = wordListJohn;
        }
        else if(choice == "2")
        {
            scriptureference.Add(ref2);
            scriptureword = wordListProverbs;
        }
        else{
            Console.WriteLine("Please select a valid choice.");
            return;
        }

        Scriptures scriptures = new Scriptures(scriptureference, scriptureword);

        Console.WriteLine();
        scriptures.ShowScripture();

        scriptures.HideRandomWords();
    }
}