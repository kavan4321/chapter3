using chapter3.Model;
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
     
        public double EntryValue { get; set; }

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
   
        public bool Cel { get; set; }
       
        public bool SecondCel { get; set; }
        public bool Fah { get; set; }

        public bool SecondFah { get; set; }

        public bool Kelvin { get; set; }

        public bool SecondKelvin { get; set; }


        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Page2ViewModel()
        {
            _page2Model = new Page2Model();
            ReturnCommand = new Command(PerformAction);
            MethodCalling();
        }


        public void  MethodCalling()
        {
            _page2Model.EntryValue=EntryValue;
            _page2Model.Answer=Answer;
            _page2Model.Cel=Cel;
            _page2Model.SecondCel=SecondCel;
            _page2Model.Fah=Fah;
            _page2Model.SecondFah=SecondFah;
            _page2Model.Kelvin=Kelvin;
            _page2Model.SecondKelvin=SecondKelvin;
        }

        public void PerformAction()
        {
            if (Cel == true && SecondCel == true)
            {
                Answer = (EntryValue);
            }
            else if (Cel == true && SecondFah == true)
            {
                Answer = ((EntryValue * 9 / 5) + 32);
            }
            else if (Cel == true && SecondKelvin == true)
            {
                Answer = (EntryValue + 273.15);
            }
            else if (Fah == true && SecondCel == true)
            {
                Answer = ((EntryValue - 32) * 5 / 9);
            }
            else if (Fah == true && SecondFah == true)
            {
                Answer = EntryValue;
            }
            else if (Fah == true && SecondKelvin == true)
            {
                Answer = (EntryValue - 32) * 5 / 9 + 273.15;
            }
            else if (Kelvin == true && SecondCel == true)
            {
                Answer = (EntryValue - 273.15);
            }
            else if (Kelvin == true && SecondFah == true)
            {
                Answer = (EntryValue - 273.15) * 9 / 5 + 32;
            }
            else if( Kelvin ==true && SecondKelvin ==true )
            {
                Answer = EntryValue;
            }
            else
            {
                Toast.Make("Please Select Option",CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
        }
    }
}
