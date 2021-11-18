using System;
using System.Collections.Generic;

namespace Kino
{
    public class Theater
    {
        private List<Movie> _movies;

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public int UniqueWatchersCount
        {
            get { throw new NotImplementedException(); }
        }

        public List<Movie> GetLowWatchedMovies(int threshold)
        {
            throw new NotImplementedException();
        }

        private List<Watcher> GetAllWatchers()
        {
            throw new NotImplementedException();
        }
    }
}
