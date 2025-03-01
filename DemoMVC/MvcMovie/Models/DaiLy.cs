namespace MvcMovie.Models;

public class DaiLy
{
    public string MaDaiLy { get; set; } = string.Empty;
    public string TenDaiLy { get; set; } = string.Empty;
    public string DiaChi { get; set; } = string.Empty;
    public string NguoiDaiDien { get; set; } = string.Empty;
    public string DienThoai { get; set; } = string.Empty;

    // Liên kết với HeThongPhanPhoi
    public string MaHTPP { get; set; } = string.Empty;
    public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
}
