using System.ComponentModel.DataAnnotations;

public class Photos
{
    public int albumId { get; set; }
    public int id { get; set; }
    public string? title { get; set; }
    public string? url { get; set; }
    public string? thumbnailUrl { get; set; }
    
    
}