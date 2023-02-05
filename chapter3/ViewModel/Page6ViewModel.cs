using chapter3.Model.Tip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chapter3.ViewModel.Tip
{
     public class Page6ViewModel : INotifyPropertyChanged
    {
        public ICommand BillCommand => new Command(BillEntry);

        public ICommand TipCommand => new Command(TipChange);
        public Double BillAmount { get; set; }
        public Double TipValue { get; set; }
        private Double _tip;
        private Double _tipvalue;
        


        public Double TipTotal
        {
            get { return _tip; }

            set
            {
                _tip = value;
                OnPropertyChanged();
            }
        }

        public Double Tip
        {
            get { return _tipvalue; }

            set
            {
                _tipvalue = value;
                OnPropertyChanged();
            }
        }

        public Double Split { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public void BillEntry()
        {
            TipTotal = BillAmount;
        }
        public void TipChange()
        {
            Tip = TipValue;
        }
    }
}