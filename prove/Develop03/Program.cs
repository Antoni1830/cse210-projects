using System;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

public class ScriptureWord
{
    private string word;
    private bool is_hidden;

    public ScriptureWord(string word)
    {
        this.word = word;
        this.is_hidden = false;
    }
}

public class ScriptureReference
{
    private string book;
    private int start_chapter;
    private int start_verse;
    private int end_chapter;
    private int end_verse;

    public ScriptureReference(string book, int start_chapter, int start_verse, int end_chapter = 0, int end_verse = 0)
    {
        this.book = book;
        this.start_chapter = start_chapter;
        this.start_verse = start_verse;
        this.end_chapter = end_chapter != 0 ? end_chapter : start_chapter;
        this.end_verse = end_verse != 0 ? end_verse : start_verse;
    }

    public override string ToString()
    {
        return $"{this.book} {this.start_chapter}:{this.start_verse}" + (this.start_chapter != this.end_chapter || this.start_verse != this.end_verse ? $"-{this.end_chapter}:{this.end_verse}" : "");
    }
}

public class Scripture
{
    private ScriptureReference reference;
    private string text;
    private List<ScriptureWord> words;
    private List<ScriptureWord> hidden_words;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = new List<ScriptureWord>();
        foreach (string word in text.Split())
        {
            this.words.Add(new ScriptureWord(word));
        }
        this.hidden_words = new List<ScriptureWord>();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        ScriptureWord word = this.words[random.Next(this.words.Count)];
        if (!word.is_hidden)
        {
            word.is_hidden = true;
            this.hidden_words.Add(word);
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(this.reference);
        foreach (ScriptureWord word in this.words)
        {
            Console.Write(word.is_hidden ? "_" : word.word);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        Scripture scripture = new Scripture(new ScriptureReference("John", 3, 16), "For God so loved the world, that he gave his only Son, that whoever believes in him shall not perish, but have eternal life.");
        while (scripture.hidden_words.Count < scripture.words.Count)
        {
            scripture.Display();
            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                break;
            }
            scripture.HideRandomWord();
        }
    }
}



