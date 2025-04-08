using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _bookChapter;
    private string _verseOpen;
    private string _verseClose;
    private List<int> _verses;

    public void SetReference(string input)
    {
        {
            List<string> referenceSplit = new List<string>(input.Split(new char[] {':'}));

            _verses = new List<int>{};
            _bookChapter = referenceSplit[0];
            string verse = referenceSplit[1];

            if(verse.Contains('-') == true)
            {
                List<string> verses = new List<string>(verse.Split(new char[] {'-'}));
                _verseOpen = verses[0];
                _verseClose = verses[1];
            }

            else if (verse.Contains('-') == false)
            {
                _verseOpen = verse;
                _verseClose = "VOID";
            }

            if(_verseClose != "VOID")
            {
            int intVerseClose = int.Parse(_verseClose);
            int intVerseOpen = int.Parse(_verseOpen);
            for(int i = intVerseOpen; i == intVerseClose; i++)
            {
                _verses.Add(i);
            }
            }

            else if(_verseClose == "VOID")
            {
                int intVerseOpen = int.Parse(_verseOpen);
                _verses.Add(intVerseOpen);
            }
        }
    }

    public void Display()
    {
        if (_verseClose == "VOID")
        {
            Console.Write($"{_bookChapter} : {_verseOpen}");
        }
        else
        {
            Console.Write($"{_bookChapter} : {_verseOpen}-{_verseClose}");
        }
    }

    public List<int> ReturnVerseList()
    {
        return _verses;
    }
    public int ReturnNumberVerses()
    {
        int numberVerses = _verses.Count();
        return numberVerses;
    }
}