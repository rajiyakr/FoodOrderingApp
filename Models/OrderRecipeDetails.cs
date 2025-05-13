using System.Text.Json.Serialization;

namespace FoodApp.Models
{
    public class OrderRecipeDetails
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("cooking_time")]
        public int? CookingTime { get; set; }

        [JsonPropertyName("image_url")]
        public string? Image_url { get; set; }

        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }

    public class Ingredient
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string? unit { get; set; }
    }
}
