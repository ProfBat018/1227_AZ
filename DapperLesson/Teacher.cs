namespace DapperLesson;

public class Teacher 
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public Person Person { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\t" +
               $"Subject: {Subject}";
    }
}
