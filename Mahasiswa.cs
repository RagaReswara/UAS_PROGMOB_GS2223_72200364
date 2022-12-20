using System.ComponentModel.DataAnnotations;

public class Mahasiswa
{
    public int id { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Name is too long")]
    public string? nama { get; set; }

    [Required]
    [StringLength(8, ErrorMessage = "NIM is too long")]
    public string? nim { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Alamat is too long")]
    public string? alamat { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Email is too long")]
    public string? email { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Foto is too long")]
    public string? foto { get; set; }
    
    public string? nim_progmob { get; set;}
    public string? nim_cari {get;set;}
    
}