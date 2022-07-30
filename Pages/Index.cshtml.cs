using BMICalculator.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BMICalculator.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        [Display(Name = "Height (in cm)")]
        public double Height { get; set; } = 156;

        [Display(Name = "Weight (in kg)")]
        public double Weight { get; set; } = 70;

        public double Result { get; set; }

        
        public List<string> DisplayResults = new List<string>();


        public void OnPost()
        {
            Height /= 100;
            Result = Weight / (Height * Height);

            AllResults.DisplayAllResults.Add($"Your BMI is: {Math.Round(Result, 1)}");

            DisplayResults.AddRange(AllResults.DisplayAllResults);
        
        }
        public void OnGet()
        {

        }
    }
}