using System.Data;
using System.Runtime.CompilerServices;

public class Scripture
{
    private List<string> _scriptures;
    private List<string> _hiddenWords;

    public Scripture()
    {
        _scriptures = new List<string>{};
        _hiddenWords = new List<string>{};
    }

    public void AddVerse(string verse)
    {
        List<string> words = new List<string>(verse.Split(new char[] {' ',':',';','(',')','?','!','.',',','-'}));
        _scriptures.Add("\n");
        foreach(string word in words)
        {
            if(word != " ")
            {
                _scriptures.Add(word);
            }
        }
    }

    public void DisplayScripture(Reference reference)
    {

        //Console.Clear();

        foreach(string word in _scriptures)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine("");
    }

    public void HideRandomWord()
    {
        Random rnd = new Random();
        string word = "";
        int index = 0;
        while(true)
            {
                index = rnd.Next(_scriptures.Count);
                word = _scriptures[index];
                if(word.Contains("_") == false)
                {
                    break;
                }
            }
        
        _hiddenWords.Add(word);
        
        List<string> letters = new List<string>{};

        for(int i=0; i < word.Length; i++)
        {
            letters.Add("_");
        }

        string hiddenWord = string.Join("", letters);

        _scriptures.RemoveAt(index);
        _scriptures.Insert(index, hiddenWord);
    }

    public int CompareScripToHidden()
    {
        int remainder = _scriptures.Count() - _hiddenWords.Count();
        return remainder;
    }
}