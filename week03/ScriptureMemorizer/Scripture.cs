using System.Data;
using System.Runtime.CompilerServices;

public class Scripture
{
    private List<Word> _scriptures;
    private List<Word> _hiddenWords;

    public Scripture()
    {
        _scriptures = new List<Word>{};
        _hiddenWords = new List<Word>{};
    }

    public void AddVerse(string verse)
    {
        List<string> words = new List<string>(verse.Split(new char[] {' ',':',';','(',')','?','!','.',',','-'}));
        
        foreach(string word in words)
        {
            if(word != " " && word != "")
            {
                Word newWord = new Word(word);
                _scriptures.Add(newWord);
            }
        }
    }

    public void DisplayScripture(Reference reference)
    {

        //Console.Clear();

        foreach(Word word in _scriptures)
        {
            word.Display();
        }
        Console.WriteLine("");
    }

    public void HideRandomWord()
    {
        Random rnd = new Random();
        Word word;
        int index = 0;
        while(true)
            {
                index = rnd.Next(_scriptures.Count);
                word = _scriptures[index];
                if(word.ReturnIfHidden() == false)
                {
                    break;
                }
            }
        word.HideWord();
        
        _hiddenWords.Add(word);
        

    }

    public int CompareScripToHidden()
    {
        int remainder = _scriptures.Count() - _hiddenWords.Count();
        return remainder;
    }
}