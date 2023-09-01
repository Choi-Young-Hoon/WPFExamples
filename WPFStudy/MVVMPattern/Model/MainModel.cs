using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.Model
{
    // 모델을 정의하기 위해 INotifyPropertyChanged 를 상속받는다.
    internal class MainModel : INotifyPropertyChanged
    {
        private int _inputNumber;
        public int InputNumber
        {
            get => this._inputNumber;
            set
            {
                this._inputNumber = value;
                this.OutputNumber = value * 2;
                OnPropertyChanged("InputNumber");// UI에 InputNumber를 갱신한다.
            }
        }

        private int _outputNumber;
        public int OutputNumber
        {
            get => this._outputNumber;
            set
            {
                this._outputNumber = value;
                OnPropertyChanged("OutputNumber"); // UI에 OutputNumber를 갱신한다.
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
