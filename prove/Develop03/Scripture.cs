class Scripture
{
    List<Word> _words;
    // TODO: add scripture ref

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        //TODO Add scripture ref here! Use bookName, chapter, and verse to create a ref.
        _words = ConvertToWords(text);
        
    }

    public Scripture(string bookName, int chapter, int startVerse, int verse, string text)
    {
        //TODO
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }


    //ConvertToWords turns paragraph in text parameter to a list of words. This list of words is returned. 
    
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