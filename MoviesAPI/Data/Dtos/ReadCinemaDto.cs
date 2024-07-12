using MoviesAPI.Models;

namespace MoviesAPI.Data.Dtos;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AddressId { get; set; }
    public virtual Address Address { get; set; }
    public virtual ICollection<Session> Sessions { get; set; }
}
