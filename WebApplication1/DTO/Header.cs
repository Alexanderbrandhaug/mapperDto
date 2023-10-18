namespace WebApplication1.DTO;

public class Header
{
    public object messageType { get; set; }
    public object includesLookupTexts { get; set; }
    public string tenantId { get; set; }
    public string integrationId { get; set; }
    public object correlationId { get; set; }
}