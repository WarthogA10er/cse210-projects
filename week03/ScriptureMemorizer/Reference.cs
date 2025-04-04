using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string reference)
    {
        List<string> parts;
        parts = new List<string>(reference.Split(new char[] { ' ', ':', '-'}, StringSplitOptions.RemoveEmptyEntries));
        if (parts.Count() == 3)
        {
            _book = parts[0];
            _chapter = parts[1];
            _verse = parts[2];
            _endVerse = parts[3];
        }

        else if (parts.Count() == 2)
        {
            _book = parts[0];
            _chapter = parts[1];
            _verse = parts[2];
            _endVerse = "VOID";
        }
    }

        public void Display()
        {
            if (_endVerse == "VOID")
            {
                Console.Write($"{_book} {_chapter}:{_verse}");
            }
            else
            {
                Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse}");
            }
        }
}    
