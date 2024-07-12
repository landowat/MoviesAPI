﻿using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "Cinema Name is Mandatory")]
    public string Name { get; set; }
    public int AddressId { get; set; }
}
