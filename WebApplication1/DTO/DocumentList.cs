namespace WebApplication1.DTO;

public class DocumentList
{
    
    public string id { get; set; }
    public string name { get; set; }
    public string extension { get; set; }
    public int byteCount { get; set; }
    public string downloadUrl { get; set; }
    public object bytes { get; set; }
    public int type { get; set; }
}