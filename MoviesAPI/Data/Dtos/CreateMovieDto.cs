using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class CreateMovieDto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Movie Title is mandatory")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Movie Genre is mandatory")]
    [MaxLength(50, ErrorMessage = "The size should be less than 50 characters")]
    public string Genre { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "The duration should be between 70 and 600 minutes")]
    public int Duration { get; set; }
}
