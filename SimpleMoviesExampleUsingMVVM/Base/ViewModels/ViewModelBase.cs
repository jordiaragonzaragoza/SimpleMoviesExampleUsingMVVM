namespace SimpleMoviesExampleUsingMVVM.Base.ViewModels
{
    public abstract class ViewModelBase<T> : ObservableViewModelBase
    {
        #region Constructor

        protected ViewModelBase(T model)
        {
            Model = model;
        }

        #endregion

        #region Properties

        public T Model { get; set; }

        #endregion

    }
}