using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace FoodApp.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [JsonPropertyName("image_url")]
        public string? Image_url { get; set; }
        [Required]
        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }
        [Required]
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        public string? UserId {  get; set; }
        public string? RecipeId {  get; set; }


    }
}
