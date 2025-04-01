using System.Collections.Generic;

public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string _studentName, string _topic, string title) : base(_studentName, _topic)
    {
        _title = title;
    }

    public string GetWrtitingInformation()
    {
        return $"{_title}, by {_studentName}";
    }

}