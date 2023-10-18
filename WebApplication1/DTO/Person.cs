namespace WebApplication1.DTO;

public class Person
{
    public Timeline timeline { get; set; }
    public object recordState { get; set; }
    public object approvalState { get; set; }
    public object currentRecordTimestamp { get; set; }
}