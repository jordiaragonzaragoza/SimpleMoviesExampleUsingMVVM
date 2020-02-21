using SimpleMoviesExampleUsingMVVM.ViewModels;

namespace SimpleMoviesExampleUsingMVVM.Views
{
    public partial class MoviesView
    {
        public MoviesView()
        {
            InitializeComponent();
            //Set the Data Context
            var moviesViewModel = new MoviesViewModel();
            DataContext = moviesViewModel;
        }
    }
}
