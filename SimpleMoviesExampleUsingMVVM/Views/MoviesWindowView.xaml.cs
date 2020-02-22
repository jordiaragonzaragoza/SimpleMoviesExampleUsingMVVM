using SimpleMoviesExampleUsingMVVM.ViewModels;

namespace SimpleMoviesExampleUsingMVVM.Views
{
    public partial class MoviesWindowView
    {
        public MoviesWindowView()
        {
            InitializeComponent();
            //Set the Data Context
            var moviesViewModel = new MoviesViewModel();
            DataContext = moviesViewModel;
        }
    }
}
