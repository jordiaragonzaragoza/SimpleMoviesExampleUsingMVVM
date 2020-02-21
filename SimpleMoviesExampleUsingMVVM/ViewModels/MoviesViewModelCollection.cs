using System.Collections.Generic;
using SimpleMoviesExampleUsingMVVM.Base.ViewModels;
using SimpleMoviesExampleUsingMVVM.Models;

namespace SimpleMoviesExampleUsingMVVM.ViewModels
{
    public class MoviesViewModelCollection : ViewModelBaseCollection<MovieViewModel, Movie>
    {
        public MoviesViewModelCollection(IEnumerable<Movie> lista)
            : base(lista)
        {
        }
    }
}