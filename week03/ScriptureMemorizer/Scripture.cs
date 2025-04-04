using System.Runtime.CompilerServices;

public class Scripture
{
    private string _scripture = ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    
    private List<string> _word;

    public Scripture()
    {
        _word = new List<string>(_scripture.Split(new char[] { ' ', ',', '.', ':', ';', '-','(', ')'}, StringSplitOptions.RemoveEmptyEntries));
    }

    public void HideRandomWord()
    {
        
    }
    
    public void DisplayScripture()
    {

    }
}