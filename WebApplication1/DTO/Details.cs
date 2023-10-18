namespace WebApplication1.DTO;

public class Details
{
    public string secondLastName { get; set; }
    public string nationality { get; set; }
    public string address { get; set; }
    public string address2 { get; set; }
    public string zip { get; set; }
    public string city { get; set; }
    public string country { get; set; }
    public string phonePrivate { get; set; }
    public string phoneMobile { get; set; }
    public string ssn { get; set; }
    public int queueNumber { get; set; }
    public bool isInternal { get; set; }
    public object rank { get; set; }
    public List<DocumentList> documentList { get; set; }
}