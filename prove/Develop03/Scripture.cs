using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;  
    private List<Word> _words = new List<Word>();  
    private Random _rand = new Random();  

    static string ScriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

    public Scripture(Reference reference)
    {
        _reference = reference;
    }

    public class Word
    {
        public string Text { get; set; }
        public bool IsHidden { get; set; }  

        public Word(string text)
        {
            Text = text;
            IsHidden = false;  
        }
    }

    public void AddScriptureToList()
    {
        string[] scriptureWords = ScriptureText.Split(' ');

        foreach (string word in scriptureWords)
        {
            _words.Add(new Word(word)); 
        }
    }

    public string GetDisplayText()
    {
        List<string> wordList = _words.ConvertAll(word => word.Text);  
        return string.Join(" ", wordList);  
    }

    public void HideRandomWord()
    {
        int randomIndex;
        do
        {
            randomIndex = _rand.Next(0, _words.Count); 
        }
        while (_words[randomIndex].IsHidden);

        _words[randomIndex].Text = "_"; 
        _words[randomIndex].IsHidden = true; 
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true; 
    }
}
