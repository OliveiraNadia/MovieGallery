using System;

namespace Movie.Gallery.Application.Queries.GetMovies
{
    public struct GetMovieQuery
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Direction { get; set; }
        public DateTime Year { get; set; }
        public int Duration { get; set; }
    }
}
