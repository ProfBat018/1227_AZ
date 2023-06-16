namespace DapperLesson;

public class Student
{
    public int Id { get; set; }
    public int Grade { get; set; }
    public Person Person { get; set; }
    
    public override string ToString()
    {
        return $"Id: {Id}\t" +
               $"Grade: {Grade}\t" +
               $"Person: {Person}";
    }
}