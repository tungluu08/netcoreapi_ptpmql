namespace BaiThucHanh.Models
{
    public class GradeModel
    {
        public float A { get; set; } // Điểm thành phần A
        public float B { get; set; } // Điểm thành phần B
        public float C { get; set; } // Điểm thành phần C
        public float FinalScore { get; set; } // Điểm tổng
        public string Grade { get; set; } = string.Empty; // Xếp loại

        public void CalculateGrade()
        {
            FinalScore = A * 0.6f + B * 0.3f + C * 0.1f;

            if (FinalScore >= 9)
                Grade = "A";
            else if (FinalScore <= 7)
                Grade = "B";
            else
                Grade = "C";
        }
    }
}
