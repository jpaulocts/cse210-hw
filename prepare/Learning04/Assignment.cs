using System;

public class Assignment 
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetNameStudent()
    {
        return _studentName;
    }
    public string GetSummary()
    {
        string summary  = $"Student: {_studentName} - Topic: {_topic}";

        return summary;
    }
}