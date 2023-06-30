using System;

public class WrittingAssignment : Assignment 
{
    private string _title;


    public WrittingAssignment(string name, string section, string title) : base(name, section)
    {
        _title = title;
    }

    public string GetWrittingInformation()
    {
        string  authorName = GetNameStudent();
        return $" Title: {_title} by {authorName}";
    }
}