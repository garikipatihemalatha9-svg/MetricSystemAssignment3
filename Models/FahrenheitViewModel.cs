using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class FahrenheitViewModel
    {
        [Required(ErrorMessage = "Please enter a Fahrenheit value.")]
        public double? Fahrenheit { get; set; }

        public double? Celsius { get; set; }
    }
}
