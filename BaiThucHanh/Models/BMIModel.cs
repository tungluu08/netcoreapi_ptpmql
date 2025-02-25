namespace BaiThucHanh.Models
{
    public class BMIModel
    {
        public float Height { get; set; } // Chiều cao (m)
        public float Weight { get; set; } // Cân nặng (kg)

        public float BMI { get; set; } // Chỉ số BMI
         
           public string BMIResult { get; set; } = string.Empty;

        public void CalculateBMI()
        {
            BMI = Weight / (Height * Height);
            if (BMI < 18.5)
                BMIResult = "Bạn đang thiếu cân!";
            else if (BMI < 24.9)
                BMIResult = "Bạn có cân nặng bình thường!";
            else if (BMI < 29.9)
                BMIResult = "Bạn đang thừa cân!";
            else
                BMIResult = "Bạn bị béo phì!";
        }
    }
}


