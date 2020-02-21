using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SimpleMoviesExampleUsingMVVM.Base.ViewModels
{
    public abstract class ViewModelBaseCollection<ViewModel, Model> : ObservableCollection<ViewModel>
    {
        #region Fields

        private List<Model> _modelCollection;

        #endregion

        #region Constructor
        protected ViewModelBaseCollection()
        {
        }
       
        protected ViewModelBaseCollection(IEnumerable<Model> domainCollection)
        {
            // Set the domain collection
            _modelCollection = domainCollection.ToList();

            foreach (var domainObject in domainCollection)
            {
                var paramList = new object[] { domainObject };
                var wrapperObject = (ViewModel)Activator.CreateInstance(typeof(ViewModel), paramList);
                Add(wrapperObject);
            }
        }

        #endregion

        #region Propiedades

        public IList<Model> DomainCollection { get { return _modelCollection; } }

        #endregion
    }
}