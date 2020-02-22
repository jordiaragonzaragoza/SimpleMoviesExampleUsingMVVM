using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SimpleMoviesExampleUsingMVVM.Base.ViewModels
{
    public abstract class ViewModelCollectionBase<ViewModel, Model> : ObservableCollection<ViewModel>
    {
        #region Fields

        private List<Model> _modelCollection;

        #endregion

        #region Properties
        public IList<Model> DomainCollection { get { return _modelCollection; } }

        #endregion

        #region Constructor

        protected ViewModelCollectionBase(IEnumerable<Model> modelCollection)
        {
            // Set the domain collection
            _modelCollection = modelCollection.ToList();

            foreach (var domainObject in modelCollection)
            {
                var paramList = new object[] { domainObject };
                var wrapperObject = (ViewModel)Activator.CreateInstance(typeof(ViewModel), paramList);
                Add(wrapperObject);
            }
        }

        #endregion


    }
}