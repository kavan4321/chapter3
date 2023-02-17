using chapter3.Model.Tip;
using System.ComponentModel;

namespace chapter3.ViewModel.Tip
{
    public class Page6ViewModel : INotifyPropertyChanged
    {
        private readonly Page6Model _page6Model;

        private double _billAmount;
        public double BillAmount
        {
            get => _billAmount;
            set { 
                 _billAmount = value;
                 OnPropertyChanged();
            }
        }



        private double _tipSLider;
        public double TipSLider
        {
            get => _tipSLider;
            set
            {
                _tipSLider = value;
                OnPropertyChanged();
            }
        }



        private double _splitSlider=1;
        public double SplitSlider
        {
            get => _splitSlider;
            set
            {
                _splitSlider = value;
                OnPropertyChanged();
            }
        }




        public double Tip
        {
            get{ return (int)TipSLider; }
            
        }
       
        public double Split
        {
            get { return (int)SplitSlider; }
            
        }
      
        public double TipDisplay
        {
            get { return Math.Round(BillAmount* (Tip / 100),2); }
            
        }

        public double Total
        {
            get { return Math.Round( BillAmount + TipDisplay); } 
            
        }

        
        public double SplitsTotal
        {
            get 
            { 
                return Math.Round(Total /Split,2) ; 
            }
            
        }

       


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name = "")
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        
        public Page6ViewModel()
        {
            _page6Model =new Page6Model();
           
        }
   
    }
}