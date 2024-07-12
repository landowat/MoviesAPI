using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "Cinema Name is Mandatory")]
    public string Name { get; set; }
}
