using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SimpleMoviesExampleUsingMVVM.Base.ViewModels
{
    public abstract class ViewModelCollectionBase<TViewModel, TModel> : ObservableCollection<TViewModel>
    {
        #region Fields

        private List<TModel> _modelCollection;

        #endregion

        #region Properties
        public IList<TModel> DomainCollection { get { return _modelCollection; } }

        #endregion

        #region Constructor

        protected ViewModelCollectionBase(IEnumerable<TModel> modelCollection)
        {
            // Set the domain collection
            _modelCollection = modelCollection.ToList();

            foreach (var domainObject in modelCollection)
            {
                var paramList = new object[] { domainObject };
                var wrapperObject = (TViewModel)Activator.CreateInstance(typeof(TViewModel), paramList);
                Add(wrapperObject);
            }
        }

        #endregion


    }
}