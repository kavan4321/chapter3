using chapter3.Model.Tip;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chapter3.ViewModel.Tip
{
    public class Page6ViewModel : INotifyPropertyChanged
    {
        private  Page6Model _page6Model;

        private double _billAmount;
        public double BillAmount
        {
            get { return _billAmount; }
            set { 
                 _billAmount = value;
                 OnPropertyChanged();
            }
        }

        private double _tipSLider;
        public double TipSLider
        {
            get {return _tipSLider; }
            set
            {
                _tipSLider = value;
                OnPropertyChanged();
            }
        }

        private double _splitSlider;
        public double SplitSlider
        {
            get { return _splitSlider; }
            set
            {
                _splitSlider = value;
                OnPropertyChanged();
            }
        }

        private int _tip;
        public int Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                OnPropertyChanged();
            }
        }


        private int _split=1;
        public int Split
        {
            get { return _split; }
            set
            {
                _split = value;
                OnPropertyChanged();
            }
        }

        private double _tipDisplay;
        public double TipDisplay
        {
            get { return _tipDisplay; }
            set
            {
                _tipDisplay = value;
                OnPropertyChanged();
            }
        }



        private double _total;
        public double Total
        {
            get { return _total; }
            set
            {
                _total= value;
                OnPropertyChanged();
            }
        }

        private double _splitsTotal;     
        public double SplitsTotal
        {
            get { return _splitsTotal; }
            set
            {
                _splitsTotal= value;
                OnPropertyChanged();
            }
        }

        public void Calculation()
        {
            Tip = (int)TipSLider;
            Split = (int)SplitSlider;


            if (string.IsNullOrEmpty(BillAmount.ToString()) || string.IsNullOrWhiteSpace(BillAmount.ToString()))
            {
                Toast.Make("Please Enter Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (BillAmount < 100)
            {
                Toast.Make("Amount should greater than 100", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (BillAmount > 50000)
            {
                Toast.Make("Amount should less than 50000", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {           
                TipDisplay = Math.Round(BillAmount * (TipSLider / 100), 2);
                Total = Math.Round((BillAmount + TipDisplay),2);
                SplitsTotal = Math.Round(Total / Split, 2);
            }
        }
       

        public void MethodCalling()
        {
            _page6Model.BillAmount= BillAmount;
            _page6Model.Tip=Tip;
            _page6Model.TipSlider = TipSLider;
            _page6Model.Split=Split;
            _page6Model.SplitSlider=SplitSlider;
            _page6Model.TipDisplay=TipDisplay;
            _page6Model.Total = Total;
            _page6Model.SplitTotal = SplitsTotal;

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public Page6ViewModel()
        {
            _page6Model =new Page6Model();
            MethodCalling(); 
        }
   
    }
}