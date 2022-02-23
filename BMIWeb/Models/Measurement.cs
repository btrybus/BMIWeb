namespace BMIWeb.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public BMI BMI {
            get => new BMI(Weight, Height);
        }
    }
}
