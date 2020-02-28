using System.Windows.Input;
using SimpleMoviesExampleUsingMVVM.Base.Commands;
using SimpleMoviesExampleUsingMVVM.Base.ViewModels;
using SimpleMoviesExampleUsingMVVM.Repository;

namespace SimpleMoviesExampleUsingMVVM.ViewModels
{
    public class MoviesViewModel : ObservableViewModelBase
    {

        #region Fields

        private MovieViewModel _selectedMovie;
        private MoviesViewModelCollection _moviesCollection;

        private RelayCommand _previousMovieCommand;
        private RelayCommand _nextMovieCommand;

        #endregion

        #region Properties

        public MovieViewModel SelectedMovie
        {
            get => _selectedMovie;
            set
            {
                if (_selectedMovie != value)
                {
                    _selectedMovie = value;

                    // Update button status when selected movie changes.
                    _previousMovieCommand.RaiseCanExecuteChanged();
                    _nextMovieCommand.RaiseCanExecuteChanged();

                    RaisePropertyChanged("SelectedMovie");
                }
            }
        }

        public MoviesViewModelCollection MoviesCollection
        {
            get => _moviesCollection;
            set
            {
                if (_moviesCollection != value)
                {
                    _moviesCollection = value;
                    RaisePropertyChanged("MoviesCollection");
                }
            }
        }

        #endregion

        #region Constructor

        public MoviesViewModel()
        {
            LoadMovies();
        }


        #endregion

        #region Methods

        public void LoadMovies()
        {
            MoviesCollection = new MoviesViewModelCollection(MoviesRepository.GetAllMovies());
        }

        private void GetMovies(int id)
        {
            SelectedMovie = new MovieViewModel(MoviesRepository.GetMovieById(id));

            _previousMovieCommand.RaiseCanExecuteChanged();
            _nextMovieCommand.RaiseCanExecuteChanged();
        }


        #endregion

        #region Events

        #endregion

        #region Commands


        public ICommand PreviousMovieCommand
        {
            get
            {
                return _previousMovieCommand
                    ?? (_previousMovieCommand = new RelayCommand(PreviousMovieExecute, PreviousMovieCanExecute));
            }
        }

        //Checks if movie exist
        private bool PreviousMovieCanExecute()
        {
            if (SelectedMovie == null)
                return false;

            return SelectedMovie.Id > 1;
        }

        private void PreviousMovieExecute()
        {
            GetMovies(SelectedMovie.Id - 1);
        }


        public ICommand NextMovieCommand
        {
            get
            {
                return _nextMovieCommand
                    ?? (_nextMovieCommand = new RelayCommand(NextMovieExecute, NextMovieCanExecute));
            }
        }

        //Checks if movie exist
        private bool NextMovieCanExecute()
        {
            if (SelectedMovie == null)
                return false;

            if (SelectedMovie.Id < MoviesRepository.GetTotalMovies())
                return true;

            return false;
        }

        private void NextMovieExecute()
        {
            GetMovies(SelectedMovie.Id + 1);
        }


        #endregion
    }
}