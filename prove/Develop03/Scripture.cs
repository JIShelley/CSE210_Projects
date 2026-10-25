class Scripture
{
    List<Word> _words;
    
    ScriptureReference _reference;

    private Random _random = new Random();

    

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);   
    }

    //This hides three random words and checks to make sure they aren't already hidden. 
    //It stops when there are no more words to hide.
    public bool HideSomeWords(int count = 3)
    {
        List<Word> visibleWords = new List<Word>();
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }


        return visibleWords.Count == 0;
    }

    //Grabs reference data from ScriptureReference and displays it with the verse(s)
    public void ShowScripture()
    {
        _reference.DisplayScriptureReference();
        Console.WriteLine();
        
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    private int NumberOfHiddenWords()
    {
        int hiddenCount = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenCount++;
            }
        }
        return hiddenCount;
    }

    //ConvertToWords turns paragraph in text parameter to a list of words. 
    //This list of words is returned. 
    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }

        return tempWords;
    }




}