using chapter3.Model;
using chapter3.Model.Tip;
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chapter3.ViewModel.Temp
{
    class Page2ViewModel : INotifyPropertyChanged
    {
        private readonly Page2Model _page2Model;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ReturnCommand { get; private set; }

        private double _entryValue;
        public double EntryValue
        {
            get
            {
                return _entryValue;
            }

            set
            {
                if (_entryValue != value)
                {
                    _entryValue = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _answer;
        public double Answer
        {
            get => _answer;
            set
            {
                _answer = value;
                OnPropertyChanged();
            }
        }

        private bool _cel;
        public bool Cel
        {
            get => _cel;
            set
            {
                _cel = value;
                OnPropertyChanged();
            }
        }

        private bool _secondCel;
        public bool SecondCel
        {
            get => _secondCel;
            set
            {
                _secondCel = value;
                OnPropertyChanged();
            }
        }

        private bool _fah;
        public bool Fah
        {
            get => _fah;
            set
            {
                _fah = value;
                OnPropertyChanged();
            }
        }

        private bool _secondFah;
        public bool SecondFah
        {
            get => _secondFah;
            set
            {
                _secondFah = value;
                OnPropertyChanged();
            }
        }

        private bool _kelvin;
        public bool Kelvin
        {
            get => _kelvin;
            set
            {
                _kelvin = value;
                OnPropertyChanged();
            }
        }

        private bool _secondKelvin;
        public bool SecondKelvin
        {
            get => _secondKelvin;
            set
            {
                _secondKelvin = value;
                OnPropertyChanged();
            }
        }


        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Page2ViewModel()
        {
            _page2Model = new Page2Model();
            ReturnCommand = new Command(PerformAction);

        }

        public void PerformAction()
        {
            if (Cel == true && SecondCel == true)
            {
                Answer = (this.EntryValue);
            }
            else if (Cel == true && SecondFah == true)
            {
                Answer = ((this.EntryValue * 9 / 5) + 32);
            }
            else if (Cel == true && SecondKelvin == true)
            {
                Answer = (this.EntryValue + 273.15);
            }
            else if (Fah == true && SecondCel == true)
            {
                Answer = ((this.EntryValue - 32) * 5 / 9);
            }
            else if (Fah == true && SecondFah == true)
            {
                Answer = this.EntryValue;
            }
            else if (Fah == true && SecondKelvin == true)
            {
                Answer = (this.EntryValue - 32) * 5 / 9 + 273.15;
            }
            else if (Kelvin == true && SecondCel == true)
            {
                Answer = (this.EntryValue - 273.15);
            }
            else if (Kelvin == true && SecondFah == true)
            {
                Answer = (this.EntryValue - 273.15) * 9 / 5 + 32;
            }
            else if( Kelvin ==true && SecondKelvin ==true )
            {
                Answer = this.EntryValue;
            }
            else
            {
                Toast.Make("Please Select Option",CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
        }
    }
}
