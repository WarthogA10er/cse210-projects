using System.Runtime.InteropServices;

public class Word
{
    private string _word;
    private bool _isHidden;
    private string _hiddenWord;

    public Word(string word)
    {
        _word = word;

        _isHidden = false;

        List<string> letters = new List<string>{};

        for(int i=0; i < word.Length; i++)
        {
            letters.Add("_");
        }

        _hiddenWord = string.Join("", letters);
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void Display()
    {
        if(_isHidden == false) 
        Console.Write($"{_word} ");

        else if(_isHidden == true)
        {
            Console.Write($"{_hiddenWord} ");
        }
    }

    public bool ReturnIfHidden()
    {
        return _isHidden;
    }
}
