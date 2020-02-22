namespace SimpleMoviesExampleUsingMVVM.Base.ViewModels
{
    public abstract class ViewModelBase<T> : ObservableViewModelBase
    {
        #region Properties

        public T Model { get; set; }

        #endregion

        #region Constructor

        protected ViewModelBase(T model)
        {
            Model = model;
        }

        #endregion

    }
}