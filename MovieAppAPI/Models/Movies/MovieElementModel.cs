using MovieAppAPI.Models.Genres;
using MovieAppAPI.Models.Reviews;

namespace MovieAppAPI.Models.Movies;

public class MovieElementModel {
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Poster { get; set; }
    public int Year { get; set; }
    public string? Country { get; set; }
    public List<ReviewShortModel>? Reviews { get; set; }
    public List<GenreModel>? Genres { get; set; }
}