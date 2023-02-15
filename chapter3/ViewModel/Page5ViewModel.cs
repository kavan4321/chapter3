using CommunityToolkit.Maui.Alerts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chapter3.ViewModel.MyCart
{
    public class Page5ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                OnPropertyChanged();
            }
        }
        public ICommand CalculateCommand { get; private set; }



        public double ModeloPrize
        {
            get => 3.55;
            set { }
        }           
        public bool ModeloCheck { get; set;}
        public ICommand ModeloMinusCommand { get; private set;}
        public ICommand ModeloPlusCommand { get; private set;}
  
        private int _modeloValue;
        public int ModeloValue
        {
            get => _modeloValue;
            set
            {
                _modeloValue = value;
                OnPropertyChanged();
            }
        }

        private int _modeloC = 1;
        public void ModeloIncrement()
        {
            _modeloC++;
            ModeloValue = _modeloC;
        }
        public void ModeloDecrement()
        {
            if (_modeloC <= 1)
            {
                Toast.Make("Can't Less than that", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                _modeloC--;
                ModeloValue = _modeloC;
            }
            
        }
        public double ModeloTotal { get; set;}
        public void ModeloCalculate()
        {
            if (ModeloCheck == true)
            {
                ModeloTotal = ModeloPrize * ModeloValue;
            }
            else
            {
                ModeloTotal = 0;
            }
        }





        public double SurelyPrize
        {
            get => 6.99;
            set { }
        }
        public bool SurelyCheck { get; set; }
        public ICommand SurelyMinusCommand { get; private set; }
        public ICommand SurelyPlusCommand { get; private set; }
        
        private int _surelyValue;
        public int SurelyValue
        {
            get => _surelyValue;
            set
            {
                _surelyValue = value;
                OnPropertyChanged();
            }
        }

        private int _surelyC = 1;

        public void SurelyIncrement()
        {
            _surelyC++;
            SurelyValue = _surelyC;
        }
        public void SurelyDecrement()
        {
            if (_surelyC <= 1)
            {
                Toast.Make("Can't Less than that", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                _surelyC--;
                SurelyValue = _surelyC;
            }

        }

        public double SurelyTotal { get; set; }
        public void SurelyCalculate()
        {
            if (SurelyCheck == true)
            {
                SurelyTotal = SurelyPrize * SurelyValue;
            }
            else
            {
                SurelyTotal = 0;
            }
        }






        public double BaiPrize
        {
            get => 3.55;
            set { }
        }
        public bool BaiCheck { get; set; }
        public ICommand BaiMinusCommand { get; private set; }
        public ICommand BaiPlusCommand { get; private set; }
        
        private int _baiValue;
        public int BaiValue
        {
            get => _baiValue;
            set
            {
                _baiValue = value;
                OnPropertyChanged();
            }
        }

        private int _baiC = 1;
       
        public void BaiIncrement()
        {
            _baiC++;
            BaiValue = _baiC;
        }
        public void BaiDecrement()
        {
            if (_baiC <= 1)
            {
                Toast.Make("Can't Less than that", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                _baiC--;
                BaiValue = _baiC;
            }

        }

        public double BaiTotal { get; set; }
       
        public void BaiCalculate()
        {
            if (BaiCheck == true)
            {
                BaiTotal = BaiPrize * BaiValue;
            }
            else
            {
                BaiTotal = 0;
            }
        }



        public string PromoCode { get; set; }

        public ICommand PromoCommand { get; private set; }

        public bool Visible { get; set; }


        public void CheckPromo()
        {
            if (!string.IsNullOrEmpty(PromoCode))
            {
                Visible = true;
            }
            else
            {
                Visible = false;
            }
        }
        public void SubTotals()
        {
            SubTotal =Math.Round((ModeloTotal+SurelyTotal+BaiTotal),2);
        }

        public void Total()
        {
            SurelyCalculate();
            ModeloCalculate();
            BaiCalculate();
            SubTotals();
        }

        public void CommandMethods()
        {
            ModeloPlusCommand = new Command(ModeloIncrement);
            ModeloMinusCommand = new Command(ModeloDecrement);
            SurelyMinusCommand = new Command(SurelyDecrement);
            SurelyPlusCommand = new Command(SurelyIncrement);
            BaiMinusCommand = new Command(BaiDecrement);
            BaiPlusCommand = new Command(BaiIncrement);
            CalculateCommand = new Command(Total);
        }

        public Page5ViewModel()
        {
            CommandMethods();
            CheckPromo();
        }

    }
}
