using System.ComponentModel.DataAnnotations; 

namespace MetricSystem.Models 

{ 

    public class FSConversionModel 

     { 

        [Required(ErrorMessage = "FahrenheitValue is requried.")] 

        [Range(-459.67, 10000, ErrorMessage = "Fahrenheit value must be >= -459.67.")] 

        public decimal? FahrenheitValue { get; set; } 

 

        public decimal? ConvertToCelsius() 

        { 

            if (!FahrenheitValue.HasValue) return null; 

            return (FahrenheitValue.Value - 32m) * 5m/ 9m; 

        } 

    } 

} 