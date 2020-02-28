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
                if (Model.Id != value)
                {
                    Model.Id = value;
                    RaisePropertyChanged("Id");
                }
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
                if (Model.Title != value)
                {
                    Model.Title = value;
                    RaisePropertyChanged("Title");
                }
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
                if (Model.Rating != value)
                {
                    Model.Rating = value;
                    RaisePropertyChanged("Rating");
                }
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
                if (Model.Director != value)
                {
                    Model.Director = value;
                    RaisePropertyChanged("Director");
                }
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
                if (Model.Description != null)
                {
                    Model.Description = value;
                    RaisePropertyChanged("Description");
                }
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
                if (Model.ImageSource != value)
                {
                    Model.ImageSource = value;
                    RaisePropertyChanged("ImageSource");
                }
            }
        }
    }
}