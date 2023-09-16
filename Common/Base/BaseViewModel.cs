using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common
{
    public abstract class BaseViewModel : ObservableObject
    {
        private object _currentDataContext;

        public object CurrentDataContext
        {
            get => _currentDataContext;
            set => SetProperty(ref _currentDataContext, value);
        }

        public BaseViewModel() 
        { 
        }

        public virtual void Cleanup()
        {
            //
        }

    }



}
