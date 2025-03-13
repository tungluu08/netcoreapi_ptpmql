using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class HeThongPhanPhoi
{
    [Key]
    public string MaHTPP { get; set; } = string.Empty;
    public string TenHTPP { get; set; } = string.Empty;
}
