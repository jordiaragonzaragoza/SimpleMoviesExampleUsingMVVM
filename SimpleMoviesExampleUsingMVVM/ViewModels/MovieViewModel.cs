using SimpleMoviesExampleUsingMVVM.Base.ViewModels;
using SimpleMoviesExampleUsingMVVM.Models;

namespace SimpleMoviesExampleUsingMVVM.ViewModels
{
    public class MovieViewModel : ViewModelBase<Movie>
    {

        #region Constructor

        public MovieViewModel(Movie model)
            : base(model)
        {
        }

        #endregion


        public int Id
        {
            get
            {
                return Model.Id;
            }
            set
            {
                Model.Id = value;
                RaisePropertyChanged("Id");
            }
        }

        public string Title
        {
            get
            {
                return Model.Title;
            }
            set
            {
                Model.Title = value;
                RaisePropertyChanged("Title");
            }
        }

        public double Rating
        {
            get
            {
                return Model.Rating;
            }
            set
            {
                Model.Rating = value;
                RaisePropertyChanged("Rating");
            }
        }

        public string Director
        {
            get
            {
                return Model.Director;
            }
            set
            {
                Model.Director = value;
                RaisePropertyChanged("Director");
            }
        }

        public string Description
        {
            get
            {
                return Model.Description;
            }
            set
            {
                Model.Description = value;
                RaisePropertyChanged("Description");
            }
        }

        public string ImageSource
        {
            get
            {
                return Model.ImageSource;
            }
            set
            {
                Model.ImageSource = value;
                RaisePropertyChanged("ImageSource");
            }
        }
    }
}