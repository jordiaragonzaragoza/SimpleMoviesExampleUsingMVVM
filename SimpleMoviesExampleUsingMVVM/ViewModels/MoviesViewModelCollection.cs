using System.Collections.Generic;
using SimpleMoviesExampleUsingMVVM.Base.ViewModels;
using SimpleMoviesExampleUsingMVVM.Models;

namespace SimpleMoviesExampleUsingMVVM.ViewModels
{
    public class MoviesViewModelCollection : ViewModelCollectionBase<MovieViewModel, Movie>
    {
        public MoviesViewModelCollection(IEnumerable<Movie> moviesCollection)
            : base(moviesCollection)
        {
        }
    }
}