using MVVMPattern.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private MainModel _model = null;

        public MainViewModel()
        {
            this._model = new MainModel();
        }

        public MainModel Model
        {
            get => this._model;
            set
            {
                this._model = value;
                OnPropertyChanged("Model");
            }
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
