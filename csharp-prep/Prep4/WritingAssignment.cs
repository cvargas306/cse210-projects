
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor for the WritingAssignment class
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        
        return $"{_title} by {GetStudentName()}";
    }

    private object GetStudentName()
    {
        throw new NotImplementedException();
    }
}