// AI Example Entry.cs
using System;

public class Entry
{
    public string _prompt;
    public string _response; 
    public string _date;

    public Entry()
    {

    }
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
    public string Display()
    {
        return $"Date: {_date}\n Prompt: {_prompt}\n Response: {_response}\n";
    }
}


