using System;

public class WritingInformation : Assignment
{
    private string _title;

    public WritingInformation(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {

        return $"{_title}";
    }
}