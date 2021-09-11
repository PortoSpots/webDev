using System.ComponentModel.DataAnnotations;

public class Suggestion
{
    [Required]
    [StringLength(50, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Email is too long.")]
    // todo email validation
    public string? Email { get; set; }

    [Required]
    [StringLength(1000, ErrorMessage = "SuggestionText is too long.")]
    public string? SuggestionText { get; set; }
}