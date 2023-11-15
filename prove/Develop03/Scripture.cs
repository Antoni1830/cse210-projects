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