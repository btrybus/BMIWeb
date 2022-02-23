namespace BMIWeb.Models
{
    public class BMI
    {
        double Weight { get; set; }

        double Height { get; set; }

        public BMI(double weight, double height)
        {
            Weight = weight;
            Height = height;
        }

        public double Value
        {
            get => Weight / ((Height / 100.0) * (Height / 100.0));
        }

        public string Description
        {
            get
            {
                string description = "OK :)";

                if (Value < 18.5)
                    description = "niedowaga";
                else if (Value >= 30)
                    description = "otyłość";
                else if (Value >= 25)
                    description = "nadwaga";

                return description;

            }
        }

    }
}
