namespace SimpleMoviesExampleUsingMVVM.Base.ViewModels
{
    public abstract class ViewModelBase<TModel> : ObservableViewModelBase
    {
        #region Properties

        public TModel Model { get; set; }

        #endregion

        #region Constructor

        protected ViewModelBase(TModel model)
        {
            Model = model;
        }

        #endregion

    }
}