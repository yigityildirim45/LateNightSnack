using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models
{
    public class Recipe
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Tarif başlığı zorunludur")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Tarif açıklaması zorunludur")]
        public string Description { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Malzemeler zorunludur")]
        public string Ingredients { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Hazırlanış talimatları zorunludur")]
        public string Instructions { get; set; } = string.Empty;
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        [Required(ErrorMessage = "Hazırlanma süresi zorunludur")]
        public int PrepTime { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string GetShortDescription(int length = 100)
        {
            if (string.IsNullOrEmpty(Description)) return string.Empty;
            return Description.Length <= length ? 
                Description : 
                Description.Substring(0, length) + "...";
        }

        public string[] GetIngredientsList()
        {
            if (string.IsNullOrEmpty(Ingredients))
                return Array.Empty<string>();

            return Ingredients.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(i => i.Trim())
                            .Where(i => !string.IsNullOrWhiteSpace(i))
                            .ToArray();
        }

        public string[] GetInstructionSteps()
        {
            if (string.IsNullOrEmpty(Instructions))
                return Array.Empty<string>();

            return Instructions.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(i => i.Trim())
                             .Where(i => !string.IsNullOrWhiteSpace(i))
                             .ToArray();
        }

        public string GetPrepTimeDisplay()
        {
            return $"{PrepTime} dakika";
        }
    }
} 